using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Classes;
using DiGi.UI.WPF.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Executes the specified action while displaying an indeterminate progress window.
        /// </summary>
        /// <param name="action">The action to be executed.</param>
        /// <param name="owner">The optional owner window for the progress window.</param>
        /// <param name="text">The optional text to display in the progress window.</param>
        public static void ShowProgress(this Action action, System.Windows.Window? owner = null, string? text = null)
        {
            if (action == null)
            {
                return;
            }

            IndeterminateWindowWorker indeterminateWindowWorker = new(owner)
            {
                Text = text
            };
            indeterminateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke();
            };
            indeterminateWindowWorker.Run();
        }

        /// <summary>
        /// Executes the specified action that requires a worker with determinate progress while displaying a progress window.
        /// </summary>
        /// <param name="action">The action to be executed, receiving the determinate worker instance.</param>
        /// <param name="text">The optional text to display in the progress window.</param>
        public static void ShowProgress(this Action<IDeterminateWorker>? action, string? text = null)
        {
            if (action == null)
            {
                return;
            }

            DeterminateWindowWorker determinateWindowWorker = new()
            {
                Text = text
            };
            determinateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(determinateWindowWorker);
            };
            determinateWindowWorker.Run();
        }

        /// <summary>
        /// Executes the specified action that requires a worker with determinate progress using the provided progress bar control.
        /// </summary>
        /// <param name="action">The action to be executed, receiving the determinate worker instance.</param>
        /// <param name="progressBarControl">The progress bar control used to display progress.</param>
        /// <param name="text">The optional text to display associated with the progress operation.</param>
        public static void ShowProgress(this Action<IDeterminateWorker>? action, ProgressBarControl? progressBarControl, string? text = null)
        {
            if (action == null || progressBarControl == null)
            {
                return;
            }

            DeterminateControlWorker determinateControlWorker = new(progressBarControl)
            {
                Text = text
            };

            determinateControlWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(determinateControlWorker);
            };
            determinateControlWorker.Run();
        }

        /// <summary>
        /// Executes the specified action that requires a worker with indeterminate progress while displaying a progress window.
        /// </summary>
        /// <param name="action">The action to be executed, receiving the indeterminate worker instance.</param>
        /// <param name="owner">The optional owner window for the progress window.</param>
        /// <param name="text">The optional text to display in the progress window.</param>
        public static void ShowProgress(this Action<IIndeterminateWorker>? action, System.Windows.Window? owner = null, string? text = null)
        {
            if (action == null)
            {
                return;
            }

            IndeterminateWindowWorker indeterminateWindowWorker = new(owner)
            {
                Text = text
            };
            indeterminateWindowWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(indeterminateWindowWorker);
            };
            indeterminateWindowWorker.Run();
        }

        /// <summary>
        /// Executes the specified action that requires a worker with indeterminate progress using the provided progress bar control.
        /// </summary>
        /// <param name="action">The action to be executed, receiving the indeterminate worker instance.</param>
        /// <param name="progressBarControl">The progress bar control used to display progress.</param>
        /// <param name="text">The optional text to display associated with the progress operation.</param>
        public static void ShowProgress(this Action<IIndeterminateWorker>? action, ProgressBarControl? progressBarControl, string? text = null)
        {
            if (action == null || progressBarControl == null)
            {
                return;
            }

            IndeterminateControlWorker indeterminateControlWorker = new(progressBarControl)
            {
                Text = text
            };
            indeterminateControlWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke(indeterminateControlWorker);
            };
            indeterminateControlWorker.Run();
        }

        /// <summary>
        /// Executes the specified action while displaying indeterminate progress on the provided progress bar control.
        /// </summary>
        /// <param name="action">The action to be executed.</param>
        /// <param name="progressBarControl">The progress bar control used to display progress.</param>
        /// <param name="text">The optional text to display associated with the progress operation.</param>
        public static void ShowProgress(this Action? action, ProgressBarControl? progressBarControl, string? text = null)
        {
            if (action == null || progressBarControl == null)
            {
                return;
            }

            IndeterminateControlWorker indeterminateControlWorker = new(progressBarControl)
            {
                Text = text
            };
            indeterminateControlWorker.DoWork += (workerSender, args) =>
            {
                action.Invoke();
            };
            indeterminateControlWorker.Run();
        }
    }
}