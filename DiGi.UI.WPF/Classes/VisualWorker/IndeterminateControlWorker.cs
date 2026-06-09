using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Controls;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides an implementation of a worker that handles indeterminate progress updates for a progress bar control.
    /// </summary>
    public class IndeterminateControlWorker : ProgressBarControlWorker, IIndeterminateWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndeterminateControlWorker"/> class.
        /// </summary>
        /// <param name="progressBarControl">The progress bar control to be managed by this worker.</param>
        public IndeterminateControlWorker(ProgressBarControl progressBarControl)
            : base(progressBarControl)
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                control.IsIndeterminate = true;
            });
        }

        /// <summary>
        /// Reports a status message for the indeterminate progress operation.
        /// </summary>
        /// <param name="text">The text message to report as current progress status.</param>
        public void Report(string text)
        {
            backgroundWorker.ReportProgress(0, text);
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            control.Dispatcher.Invoke(() =>
            {
                control.Update(e.ProgressPercentage, e.UserState as string);
            });
        }
    }
}