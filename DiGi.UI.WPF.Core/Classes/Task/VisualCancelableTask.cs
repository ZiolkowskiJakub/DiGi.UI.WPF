using DiGi.Core.Classes;
using DiGi.UI.WPF.Core.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DiGi.UI.WPF.Core.Classes
{
    public class VisualCancelableTask<TCancelableTask> : IVisualCancelableTask where TCancelableTask : CancelableTask
    {
        private readonly TCancelableTask cancelableTask;
        private readonly string name;
        private readonly string description;

        public VisualCancelableTask(TCancelableTask cancelableTask, string name, string description)
        {
            this.cancelableTask = cancelableTask;
            this.name = name;
            this.description = description;

            cancelableTask.Started += (s, e) => RefreshAll();
            cancelableTask.Stopped += (s, e) => RefreshAll();
            cancelableTask.Starting += (s, e) => RefreshAll();
            cancelableTask.Stopping += (s, e) => RefreshAll();
        }

        public DiGi.Core.Enums.CancelableTaskStatus CancelableTaskStatus
        {
            get
            {
                return cancelableTask.CancelableTaskStatus;
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
                return cancelableTask.IsRunning ? "Stop" : "Start";
            }
        }

        public virtual string Status
        {
            get
            {
                return CancelableTaskStatus.ToString();
            }
        }

        public ICommand ToggleCommandAsync => new ToggleCommandAsync(async _ =>
        {
            if (cancelableTask.IsRunning)
            {
                await cancelableTask.StopAsync();
            }
            else
            {
                cancelableTask.Start();
            }

            RefreshAll();
        });

        private void RefreshAll()
        {
            Action action = new(() =>
            {
                OnPropertyChanged(nameof(CancelableTaskStatus));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(ToggleText));
                OnPropertyChanged(nameof(Status));
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

    public class VisualCancelableTask : VisualCancelableTask<CancelableTask>
    {
        public VisualCancelableTask(CancelableTask cancelableTask, string name, string description)
            : base(cancelableTask, name, description)
        {
        }
    }
}