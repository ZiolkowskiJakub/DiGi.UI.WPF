using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public class IndeterminateWindowWorker : ProgressBarWindowWorker, IIndeterminateWorker
    {
        public IndeterminateWindowWorker()
            : this(null)
        {

        }

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
