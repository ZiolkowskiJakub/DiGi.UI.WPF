using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides a worker implementation that manages a window with indeterminate progress.
    /// </summary>
    public class IndeterminateWindowWorker : ProgressBarWindowWorker, IIndeterminateWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndeterminateWindowWorker"/> class without specifying an owner window.
        /// </summary>
        public IndeterminateWindowWorker()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndeterminateWindowWorker"/> class with a specified owner window.
        /// </summary>
        /// <param name="owner">The window that owns this worker.</param>
        public IndeterminateWindowWorker(System.Windows.Window? owner)
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
        /// Reports progress by updating the status text while maintaining an indeterminate state.
        /// </summary>
        /// <param name="text">The text to be displayed as the current progress status.</param>
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