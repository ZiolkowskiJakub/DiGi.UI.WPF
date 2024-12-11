using DiGi.UI.WPF.Core.Windows;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public class IndeterminateWindowWorker : WindowWorker<ProgressBarWindow>
    {
        public IndeterminateWindowWorker()
            : this(null)
        {

        }

        public IndeterminateWindowWorker(System.Windows.Window owner)
            : base()
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window = new ProgressBarWindow()
                {
                    IsIndeterminate = true,
                    Owner = owner
                };
            });
        }

        public void Report(string text)
        {
            backgroundWorker.ReportProgress(0, text);
        }

        public override void Run()
        {
            base.Run();
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            window.Dispatcher.Invoke(() =>
            {
                window.Update(e.ProgressPercentage, e.UserState as string);
            });
        }
    }
}
