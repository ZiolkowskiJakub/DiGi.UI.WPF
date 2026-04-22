using DiGi.Core;
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
        private readonly string description;
        private readonly string name;
        
        private readonly System.Timers.Timer timer = new (1000);

        public VisualBackgroundTask(TBackgroundTask backgroundTask, string name, string description)
        {
            this.backgroundTask = backgroundTask;
            this.name = name;
            this.description = description;

            // Initialize timer for live duration updates
            timer.Elapsed += (s, e) => OnPropertyChanged(nameof(ExecutionTimeSpanText));

            backgroundTask.Started += (s, e) =>
            {
                timer.Start();
                RefreshAll();
            };

            backgroundTask.Stopped += (s, e) =>
            {
                timer.Stop();
                RefreshAll();
            };

            backgroundTask.Starting += (s, e) => RefreshAll();
            backgroundTask.Stopping += (s, e) => RefreshAll();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

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

        public string? Description
        {
            get
            {
                return description;
            }
        }

        public string? ExceptionText
        {
            get
            {
                return backgroundTask.Exception?.Message;
            }
        }

        public string ExecutionTimeSpanText
        {
            get
            {
                TimeSpan duration = backgroundTask.ExecutionTimeSpan;

                // Format: HH:mm:ss
                return string.Format("{0:D2}:{1:D2}:{2:D2}", (int)duration.TotalHours, duration.Minutes, duration.Seconds);
            }
        }

        public string? Name
        {
            get
            {
                return name;
            }
        }
        
        public virtual string Status
        {
            get
            {
                return (backgroundTask is ICancelableBackgroundTask cancelableBackgroundTask ? cancelableBackgroundTask.CancelableBackgroundTaskStatus.Description() : backgroundTask.BackgroundTaskStatus.Description()) ?? "???";
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

        public void Start()
        {
            if (backgroundTask.IsRunning)
            {
                return;
            }

            backgroundTask.Start();
            RefreshAll();
        }

        public string ToggleText
        {
            get
            {
                return backgroundTask.IsRunning ? "Stop" : "Start";
            }
        }
        
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void RefreshAll()
        {
            Action action = new(() =>
            {
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(ToggleText));
                OnPropertyChanged(nameof(ExecutionTimeSpanText));
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

        public string? TypeName
        {
            get
            {
                return backgroundTask?.GetType()?.Name;
            }
        }
    }

    public class VisualBackgroundTask : VisualBackgroundTask<IBackgroundTask>
    {
        public VisualBackgroundTask(IBackgroundTask backgroundTask, string name, string description)
            : base(backgroundTask, name, description)
        {
        }
    }
}