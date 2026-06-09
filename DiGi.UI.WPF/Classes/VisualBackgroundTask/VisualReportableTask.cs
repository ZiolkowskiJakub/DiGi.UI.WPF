using DiGi.Core.Enums;
using DiGi.Core.Interfaces;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// A visual representation of a reportable background task that tracks and displays reported values.
    /// </summary>
    /// <typeparam name="T">The type of the progress data reported by the background task.</typeparam>
    /// <typeparam name="TReportableBackgroundTask">The specific type of the reportable background task implementation.</typeparam>
    public class VisualReportableBackgroundTask<T, TReportableBackgroundTask> : VisualBackgroundTask<TReportableBackgroundTask> where TReportableBackgroundTask : IReportableBackgroundTask<T>
    {
        private T? value;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualReportableBackgroundTask{T, TReportableBackgroundTask}"/> class.
        /// </summary>
        /// <param name="reportableBackgroundTask">The reportable background task to be visually tracked.</param>
        /// <param name="name">The display name of the task.</param>
        /// <param name="description">A description of the task.</param>
        public VisualReportableBackgroundTask(TReportableBackgroundTask reportableBackgroundTask, string name, string description)
            : base(reportableBackgroundTask, name, description)
        {
            reportableBackgroundTask.ProgressChanged += (s, value) =>
            {
                Value = value;
            };

            reportableBackgroundTask.Stopped += (s, value) =>
            {
                Value = default;
            };
        }

        /// <summary>
        /// Gets or sets the current value reported by the background task.
        /// </summary>
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

        /// <summary>
        /// Gets the status of the background task, appended with the current reported value if the task is running and the value is a non-empty string.
        /// </summary>
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

    /// <summary>
    /// A visual representation of a reportable background task using the generic <see cref="IReportableBackgroundTask{T}"/> interface.
    /// </summary>
    /// <typeparam name="T">The type of the progress data reported by the background task.</typeparam>
    public class VisualReportableBackgroundTask<T> : VisualReportableBackgroundTask<T, IReportableBackgroundTask<T>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualReportableBackgroundTask{T}"/> class.
        /// </summary>
        /// <param name="reportableBackgroundTask">The reportable background task to be visually tracked.</param>
        /// <param name="name">The display name of the task.</param>
        /// <param name="description">A description of the task.</param>
        public VisualReportableBackgroundTask(IReportableBackgroundTask<T> reportableBackgroundTask, string name, string description)
            : base(reportableBackgroundTask, name, description)
        {
        }
    }
}