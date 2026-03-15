using DiGi.UI.WPF.Controls;
using System.ComponentModel;

namespace DiGi.UI.WPF.Classes
{
    public abstract class ProgressBarControlWorker : ControlWorker<ProgressBarControl>
    {
        public ProgressBarControlWorker(ProgressBarControl progressBarControl)
            : base(progressBarControl)
        {
            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

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