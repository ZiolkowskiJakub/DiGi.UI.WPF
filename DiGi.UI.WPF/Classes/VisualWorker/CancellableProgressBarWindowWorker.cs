using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Windows;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides a worker implementation that manages a <see cref="CancellableProgressBarWindow"/>, allowing for progress reporting and operation cancellation.
    /// </summary>
    public class CancellableProgressBarWindowWorker : WindowWorker<CancellableProgressBarWindow>, ICancellableWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellableProgressBarWindowWorker"/> class.
        /// </summary>
        public CancellableProgressBarWindowWorker()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellableProgressBarWindowWorker"/> class with the specified owner window.
        /// </summary>
        /// <param name="owner">The optional owner window for the progress bar window.</param>
        public CancellableProgressBarWindowWorker(System.Windows.Window? owner)
            : base()
        {
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window = new CancellableProgressBarWindow()
                {
                    Owner = owner
                };

                window.Cancelling += (sender, e) => { backgroundWorker.CancelAsync(); };
            });
        }

        /// <summary>
        /// Gets a value indicating whether a cancellation is pending.
        /// </summary>
        /// <returns>True if a cancellation is pending; otherwise, false.</returns>
        public bool CancellationPending
        {
            get
            {
                return window is null ? false : window.CancellationPending;
            }
        }

        /// <summary>
        /// Gets or sets the text displayed on the main label of the progress bar window.
        /// </summary>
        public string? Text
        {
            get
            {
                if (window is null)
                {
                    return null;
                }

                return window.Label_Main.Content.ToString();
            }

            set
            {
                if (window is null)
                {
                    return;
                }

                window.Label_Main.Content = value;
            }
        }

        /// <summary>
        /// Initiates an asynchronous cancellation of the worker's operation.
        /// </summary>
        public void CancelAsync()
        {
            backgroundWorker?.CancelAsync();
        }
    }
}