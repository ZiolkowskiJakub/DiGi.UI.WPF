using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Controls;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides an implementation of a worker that manages determinate progress updates for a ProgressBarControl.
    /// </summary>
    public class DeterminateControlWorker : ProgressBarControlWorker, IDeterminateWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeterminateControlWorker"/> class.
        /// </summary>
        /// <param name="progressBarControl">The progress bar control to be updated by this worker.</param>
        public DeterminateControlWorker(ProgressBarControl progressBarControl)
            : base(progressBarControl)
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                control.IsIndeterminate = false;
            });
        }

        /// <summary>
        /// Gets or sets the maximum value for progress reporting.
        /// </summary>
        public double Maximum { get; set; } = 100;

        /// <summary>
        /// Reports a new progress value.
        /// </summary>
        /// <param name="value">The progress value to report.</param>
        public void Report(double value)
        {
            backgroundWorker.ReportProgress(Convert.ToInt32(value / Maximum * 100));
        }

        /// <summary>
        /// Reports a new progress value along with a descriptive status message.
        /// </summary>
        /// <param name="value">The progress value to report.</param>
        /// <param name="text">The status message to display alongside the progress.</param>
        public void Report(double value, string text)
        {
            backgroundWorker.ReportProgress(Convert.ToInt32(value / Maximum * 100), text);
        }

        /// <summary>
        /// Starts the execution of the worker and configures the associated control's maximum value.
        /// </summary>
        public override void Run()
        {
            base.Run();

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                control.Maximum = Maximum;
            });
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            control.Dispatcher.Invoke(() =>
            {
                control.Update(Maximum * (Convert.ToDouble(e.ProgressPercentage) / 100), e.UserState as string);
            });
        }
    }
}