using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Core.Controls;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{    public class DeterminateControlWorker : ProgressBarControlWorker, IDeterminateWorker
    {
        public DeterminateControlWorker(ProgressBarControl progressBarControl)
            : base(progressBarControl)
        {
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                control.IsIndeterminate = false;
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
                control.Maximum = Maximum;
            });
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            control.Dispatcher.Invoke(() =>
            {
                control.Update(Maximum * (Convert.ToDouble(e.ProgressPercentage) / 100), e.UserState as string);
            });
        }
    }
}
