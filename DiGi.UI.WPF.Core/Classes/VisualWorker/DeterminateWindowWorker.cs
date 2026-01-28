using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public class DeterminateWindowWorker : ProgressBarWindowWorker, IDeterminateWorker
    {
        public DeterminateWindowWorker()
            : base()
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            if (window is not null)
            {
                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    window.IsIndeterminate = false;
                });
            }
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

            if (window is null)
            {
                return;
            }

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window.Maximum = Maximum;
            });
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            if (window is null)
            {
                return;
            }

            window.Dispatcher.Invoke(() =>
            {
                window.Update(Maximum * (Convert.ToDouble(e.ProgressPercentage) / 100), e.UserState as string);
            });
        }
    }
}