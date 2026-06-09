using DiGi.UI.WPF.Controls;
using System.ComponentModel;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides a base implementation for worker classes that manage the operational state and updates of a <see cref="ProgressBarControl"/>.
    /// </summary>
    public abstract class ProgressBarControlWorker : ControlWorker<ProgressBarControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarControlWorker"/> class.
        /// </summary>
        /// <param name="progressBarControl">The progress bar control instance that this worker will manage.</param>
        public ProgressBarControlWorker(ProgressBarControl progressBarControl)
            : base(progressBarControl)
        {
            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        /// <summary>
        /// Gets or sets the text content displayed in the main label of the associated progress bar control.
        /// </summary>
        public string? Text
        {
            get
            {
                return control.Label_Main.Content.ToString();
            }

            set
            {
                control.Label_Main.Content = value;
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            control.Dispatcher.Invoke(() =>
            {
                control.IsIndeterminate = false;
                control.Value = 0;
                control.Label_Main.Content = null;
            });
        }
    }
}