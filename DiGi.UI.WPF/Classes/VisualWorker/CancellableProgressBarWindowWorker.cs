using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Windows;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    public class CancellableProgressBarWindowWorker : WindowWorker<CancellableProgressBarWindow>, ICancellableWorker
    {
        public CancellableProgressBarWindowWorker()
            : this(null)
        {
        }

        public CancellableProgressBarWindowWorker(System.Windows.Window? owner)
            : base()
        {
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window = new CancellableProgressBarWindow()
                {
                    Owner = owner
                };

                window.Cancelling += (sender, e) => { backgroundWorker.CancelAsync(); };
            });
        }

        public bool CancellationPending
        {
            get
            {
                return window is null ? false : window.CancellationPending;
            }
        }

        public string? Text
        {
            get
            {
                if (window is null)
                {
                    return null;
                }

                return window.Label_Main.Content.ToString();
            }

            set
            {
                if (window is null)
                {
                    return;
                }

                window.Label_Main.Content = value;
            }
        }

        public void CancelAsync()
        {
            backgroundWorker?.CancelAsync();
        }
    }
}