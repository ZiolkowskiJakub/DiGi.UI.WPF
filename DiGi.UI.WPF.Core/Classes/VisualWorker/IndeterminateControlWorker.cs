using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Core.Controls;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public class IndeterminateControlWorker : ProgressBarControlWorker, IIndeterminateWorker
    {
        public IndeterminateControlWorker(ProgressBarControl progressBarControl)
            : base(progressBarControl)
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                control.IsIndeterminate = true;
            });
        }

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
