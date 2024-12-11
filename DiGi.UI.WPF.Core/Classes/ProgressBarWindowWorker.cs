using DiGi.UI.WPF.Core.Windows;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public class ProgressBarWindowWorker : WindowWorker<ProgressBarWindow>
    {
        public ProgressBarWindowWorker()
            : this(null)
        {

        }

        public ProgressBarWindowWorker(System.Windows.Window owner)
            : base()
        {
            backgroundWorker.WorkerReportsProgress = true;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window = new ProgressBarWindow()
                {
                    Owner = owner
                };
            });
        }
    }
}
