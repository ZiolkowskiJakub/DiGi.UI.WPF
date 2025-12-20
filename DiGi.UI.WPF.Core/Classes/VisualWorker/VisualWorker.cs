using DiGi.UI.WPF.Core.Interfaces;
using System.ComponentModel;

namespace DiGi.UI.WPF.Core.Classes
{    
    public abstract class VisualWorker : IVisualWorker
    {
        protected BackgroundWorker backgroundWorker = new() { WorkerReportsProgress = false };

        public VisualWorker()
        {
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        public event DoWorkEventHandler? DoWork;

        public event RunWorkerCompletedEventHandler? RunWorkerCompleted;

        public bool IsBusy
        {
            get
            {
                return backgroundWorker == null ? false : backgroundWorker.IsBusy;
            }
        }
        
        public virtual void Run()
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            DoWork?.Invoke(this, e);
        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompleted?.Invoke(this, e);
        }
    }
}
