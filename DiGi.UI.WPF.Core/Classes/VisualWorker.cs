using DiGi.UI.WPF.Core.Windows;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Core.Classes
{    
    public abstract class VisualWorker
    {
        protected BackgroundWorker backgroundWorker;

        public VisualWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = false;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        
        public event DoWorkEventHandler? DoWork;

        public virtual void Run()
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            DoWork?.Invoke(this, e);
        }
    }
}
