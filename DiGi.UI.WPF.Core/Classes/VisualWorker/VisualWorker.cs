using DiGi.UI.WPF.Core.Interfaces;
using System.ComponentModel;

namespace DiGi.UI.WPF.Core.Classes
{    
    public abstract class VisualWorker : IVisualWorker
    {
        protected BackgroundWorker backgroundWorker;

        public VisualWorker()
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = false
            };
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
