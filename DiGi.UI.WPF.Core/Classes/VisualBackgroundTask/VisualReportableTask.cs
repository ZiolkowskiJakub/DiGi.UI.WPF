using DiGi.Core.Enums;
using DiGi.Core.Interfaces;

namespace DiGi.UI.WPF.Core.Classes
{
    public class VisualReportableBackgroundTask<T, TReportableBackgroundTask> : VisualBackgroundTask<TReportableBackgroundTask> where TReportableBackgroundTask : IReportableBackgroundTask<T>
    {
        private T? value;

        public VisualReportableBackgroundTask(TReportableBackgroundTask reportableBackgroundTask, string name, string description)
            : base(reportableBackgroundTask, name, description)
        {
            reportableBackgroundTask.ProgressChanged += (s, value) =>
            {
                Value = value;
            };
        }

        public T? Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Status));
            }
        }

        public override string Status
        {
            get
            {
                string result = base.Status;
                if (backgroundTask.BackgroundTaskStatus == BackgroundTaskStatus.Running && value?.ToString() is string text && !string.IsNullOrWhiteSpace(text))
                {
                    result = $"{result} ({text})";
                }

                return result;
            }
        }
    }

    public class VisualReportableBackgroundTask<T> : VisualReportableBackgroundTask<T, IReportableBackgroundTask<T>>
    {
        public VisualReportableBackgroundTask(IReportableBackgroundTask<T> reportableBackgroundTask, string name, string description)
            : base(reportableBackgroundTask, name, description)
        {
        }
    }
}