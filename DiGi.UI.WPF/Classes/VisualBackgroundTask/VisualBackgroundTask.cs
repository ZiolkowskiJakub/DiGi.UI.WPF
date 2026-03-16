using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DiGi.UI.WPF.Classes
{
    public class VisualBackgroundTask<TBackgroundTask> : IVisualBackgroundTask where TBackgroundTask : IBackgroundTask
    {
        protected readonly TBackgroundTask backgroundTask;
        private readonly string name;
        private readonly string description;

        public VisualBackgroundTask(TBackgroundTask backgroundTask, string name, string description)
        {
            this.backgroundTask = backgroundTask;
            this.name = name;
            this.description = description;

            backgroundTask.Started += (s, e) => RefreshAll();
            backgroundTask.Stopped += (s, e) => RefreshAll();
            backgroundTask.Starting += (s, e) => RefreshAll();
            backgroundTask.Stopping += (s, e) => RefreshAll();
        }

        public DiGi.Core.Enums.BackgroundTaskStatus BackgroundTaskStatus
        {
            get
            {
                return backgroundTask.BackgroundTaskStatus;
            }
        }

        public string? Name
        {
            get
            {
                return name;
            }
        }

        public string? Description
        {
            get
            {
                return description;
            }
        }

        public string ToggleText
        {
            get
            {
                return backgroundTask.IsRunning ? "Stop" : "Start";
            }
        }

        public bool CanToggle
        {
            get
            {
                // If the task is not running, we can always start it.
                if (!backgroundTask.IsRunning)
                {
                    return true;
                }

                // If the task is running, we can only "Stop" it if it supports cancellation.
                return backgroundTask is ICancelableBackgroundTask;
            }
        }

        public string? ExceptionText
        {
            get
            {
                return backgroundTask.Exception?.Message;
            }
        }

        public virtual string Status
        {
            get
            {
                return BackgroundTaskStatus.ToString();
            }
        }

        public ICommand ToggleCommandAsync => new ToggleCommandAsync(async _ =>
        {
            if (backgroundTask.IsRunning)
            {
                if (backgroundTask is ICancelableBackgroundTask cancelableBackgroundTask)
                {
                    await cancelableBackgroundTask.StopAsync();
                }
            }
            else
            {
                backgroundTask.Start();
            }

            RefreshAll();
        });

        private void RefreshAll()
        {
            Action action = new(() =>
            {
                OnPropertyChanged(nameof(BackgroundTaskStatus));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(ToggleText));
                OnPropertyChanged(nameof(Status));
                OnPropertyChanged(nameof(ExceptionText));
                OnPropertyChanged(nameof(CanToggle));
            });

            // Sprawdzamy, czy jesteśmy w wątku UI (Windows 11 / WPF Threading Model)
            if (System.Windows.Application.Current.Dispatcher.CheckAccess())
            {
                action.Invoke();
            }
            else
            {
                // Jeśli nie, przesyłamy wykonanie do wątku UI
                System.Windows.Application.Current.Dispatcher.BeginInvoke(action);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class VisualBackgroundTask : VisualBackgroundTask<IBackgroundTask>
    {
        public VisualBackgroundTask(IBackgroundTask backgroundTask, string name, string description)
            : base(backgroundTask, name, description)
        {
        }
    }
}