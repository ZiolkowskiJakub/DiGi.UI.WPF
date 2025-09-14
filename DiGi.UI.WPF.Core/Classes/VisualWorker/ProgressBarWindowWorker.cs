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

        public ProgressBarWindowWorker(System.Windows.Window? owner)
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

        public string? Text
        {
            get
            {
                if(window is null)
                {
                    return null;
                }

                return window.Label_Main.Content.ToString();
            }

            set
            {
                if(window is null)
                {
                    return;
                }

                window.Label_Main.Content = value;
            }
        }
    }
}
