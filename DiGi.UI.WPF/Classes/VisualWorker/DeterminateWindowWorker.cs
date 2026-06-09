using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides a window-based worker implementation that supports determinate progress reporting.
    /// </summary>
    public class DeterminateWindowWorker : ProgressBarWindowWorker, IDeterminateWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeterminateWindowWorker"/> class.
        /// </summary>
        public DeterminateWindowWorker()
            : base()
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            if (window is not null)
            {
                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    window.IsIndeterminate = false;
                });
            }
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
        /// Reports a new progress value along with a status message.
        /// </summary>
        /// <param name="value">The progress value to report.</param>
        /// <param name="text">The status text to display.</param>
        public void Report(double value, string text)
        {
            backgroundWorker.ReportProgress(Convert.ToInt32(value / Maximum * 100), text);
        }

        /// <summary>
        /// Executes the worker operation and synchronizes the maximum progress value with the associated window.
        /// </summary>
        public override void Run()
        {
            base.Run();

            if (window is null)
            {
                return;
            }

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window.Maximum = Maximum;
            });
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            if (window is null)
            {
                return;
            }

            window.Dispatcher.Invoke(() =>
            {
                window.Update(Maximum * (Convert.ToDouble(e.ProgressPercentage) / 100), e.UserState as string);
            });
        }
    }
}