using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{
    public abstract class WindowWorker<TWindow> : VisualWorker where TWindow : System.Windows.Window
    {
        protected TWindow window;

        public WindowWorker()
            : base()
        {
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        public System.Windows.Window Owner
        {
            get
            {
                return window.Owner;
            }

            set
            {
                window.Owner = value;
            }
        }

        public override void Run()
        {
            base.Run();

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window.Show();
            });
        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            // Close the ProgressBarWindow on the UI thread
            window.Dispatcher.Invoke(() =>
            {
                window.Close();
            });
        }
    }
}