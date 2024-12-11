using DiGi.UI.WPF.Core.Classes;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static void ShowProgress(this Action action, System.Windows.Window owner = null)
        {
            if(action == null)
            {
                return;
            }

            IndeterminateWindowWorker indeterminateWindowWorker = new IndeterminateWindowWorker(owner);
            indeterminateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke();
            };
            indeterminateWindowWorker.Run();
        }
    }
}