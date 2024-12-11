using DiGi.UI.WPF.Core.Windows;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{    public class DeterminateWindowWorker : WindowWorker<ProgressBarWindow>
    {
        public DeterminateWindowWorker()
            : this(null)
        {

        }

        public DeterminateWindowWorker(System.Windows.Window owner)
            :base()
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window = new ProgressBarWindow()
                {
                    Owner = owner
                };
            });
        }

        public double Maximum { get; set; } = 100;

        public void Report(double value)
        {
            backgroundWorker.ReportProgress(Convert.ToInt32(value / Maximum * 100));
        }

        public void Report(double value, string text)
        {
            backgroundWorker.ReportProgress(Convert.ToInt32(value / Maximum * 100), text);
        }

        public override void Run()
        {
            base.Run();

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window.Maximum = Maximum;
            });
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            window.Dispatcher.Invoke(() =>
            {
                window.Update(Maximum * (Convert.ToDouble(e.ProgressPercentage) / 100), e.UserState as string);
            });
        }
    }
}
