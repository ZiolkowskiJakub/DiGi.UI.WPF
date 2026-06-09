using DiGi.UI.WPF.Windows;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides functionality to manage and control a <see cref="ProgressBarWindow"/> from a background worker context.
    /// </summary>
    public class ProgressBarWindowWorker : WindowWorker<ProgressBarWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarWindowWorker"/> class.
        /// </summary>
        public ProgressBarWindowWorker()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarWindowWorker"/> class with a specified owner window.
        /// </summary>
        /// <param name="owner">The optional owner window for the progress bar window.</param>
        public ProgressBarWindowWorker(System.Windows.Window? owner)
            : base()
        {
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = false;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window = new ProgressBarWindow()
                {
                    Owner = owner
                };
            });
        }

        /// <summary>
        /// Gets or sets the text displayed in the main label of the progress bar window.
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
    }
}