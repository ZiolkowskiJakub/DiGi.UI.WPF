using DiGi.Core.Classes;

namespace DiGi.UI.WPF.Core.Classes
{
    public class VisualReportableTask<T, TReportableTask> : VisualCancelableTask<TReportableTask> where TReportableTask : ReportableTask<T>
    {
        private T? value;

        public VisualReportableTask(TReportableTask reportableTask, string name, string description)
            : base(reportableTask, name, description)
        {
            reportableTask.ProgressChanged += (s, value) =>
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
                if (CancelableTaskStatus == DiGi.Core.Enums.CancelableTaskStatus.Running && value?.ToString() is string text && !string.IsNullOrWhiteSpace(text))
                {
                    result = $"{result} ({text})";
                }

                return result;
            }
        }
    }

    public class VisualReportableTask<T> : VisualReportableTask<T, ReportableTask<T>>
    {
        public VisualReportableTask(ReportableTask<T> reportableTask, string name, string description)
            : base(reportableTask, name, description)
        {
        }
    }
}