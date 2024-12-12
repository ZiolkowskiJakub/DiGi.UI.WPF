using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Core.Classes;
using DiGi.UI.WPF.Core.Controls;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static void ShowProgress(this Action action, System.Windows.Window owner = null, string text = null)
        {
            if(action == null)
            {
                return;
            }

            IndeterminateWindowWorker indeterminateWindowWorker = new IndeterminateWindowWorker(owner);
            indeterminateWindowWorker.Text = text;
            indeterminateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke();
            };
            indeterminateWindowWorker.Run();
        }

        public static void ShowProgress(this Action<IDeterminateWorker> action, System.Windows.Window owner = null, string text = null)
        {
            if (action == null)
            {
                return;
            }

            DeterminateWindowWorker determinateWindowWorker = new DeterminateWindowWorker(owner);
            determinateWindowWorker.Text = text;
            determinateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(determinateWindowWorker);
            };
            determinateWindowWorker.Run();
        }

        public static void ShowProgress(this Action<IDeterminateWorker> action, ProgressBarControl progressBarControl, string text = null)
        {
            if (action == null || progressBarControl == null)
            {
                return;
            }

            DeterminateControlWorker determinateControlWorker = new DeterminateControlWorker(progressBarControl);
            determinateControlWorker.Text = text;
            determinateControlWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(determinateControlWorker);
            };
            determinateControlWorker.Run();
        }

        public static void ShowProgress(this Action<IIndeterminateWorker> action, System.Windows.Window owner = null, string text = null)
        {
            if (action == null)
            {
                return;
            }

            IndeterminateWindowWorker indeterminateWindowWorker = new IndeterminateWindowWorker(owner);
            indeterminateWindowWorker.Text = text;
            indeterminateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(indeterminateWindowWorker);
            };
            indeterminateWindowWorker.Run();
        }

        public static void ShowProgress(this Action<IIndeterminateWorker> action, ProgressBarControl progressBarControl, string text = null)
        {
            if (action == null || progressBarControl == null)
            {
                return;
            }

            IndeterminateControlWorker indeterminateControlWorker = new IndeterminateControlWorker(progressBarControl);
            indeterminateControlWorker.Text = text;
            indeterminateControlWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(indeterminateControlWorker);
            };
            indeterminateControlWorker.Run();
        }

        public static void ShowProgress(this Action action, ProgressBarControl progressBarControl, string text = null)
        {
            if (action == null || progressBarControl == null)
            {
                return;
            }

            IndeterminateControlWorker indeterminateControlWorker = new IndeterminateControlWorker(progressBarControl);
            indeterminateControlWorker.Text = text;
            indeterminateControlWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke();
            };
            indeterminateControlWorker.Run();
        }
    }
}