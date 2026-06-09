using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides a worker implementation that manages indeterminate progress updates for a window, 
    /// allowing the operation to be cancelled.
    /// </summary>
    public class CancellableIndeterminateWindowWorker : CancellableProgressBarWindowWorker, IIndeterminateWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellableIndeterminateWindowWorker"/> class.
        /// </summary>
        public CancellableIndeterminateWindowWorker()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellableIndeterminateWindowWorker"/> class with a specified owner window.
        /// </summary>
        /// <param name="owner">The window that owns this worker.</param>
        public CancellableIndeterminateWindowWorker(System.Windows.Window? owner)
            : base(owner)
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            if (window is not null)
            {
                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    window.IsIndeterminate = true;
                });
            }
        }

        /// <summary>
        /// Reports a new progress status message to the associated window.
        /// </summary>
        /// <param name="text">The text describing the current progress state.</param>
        public void Report(string text)
        {
            backgroundWorker.ReportProgress(0, text);
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            if (window is null)
            {
                return;
            }

            window.Dispatcher.Invoke(() =>
                {
                    window.Update(e.ProgressPercentage, e?.UserState as string);
                });
        }
    }
}