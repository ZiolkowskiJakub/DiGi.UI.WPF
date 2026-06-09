using System.ComponentModel;
using System.Windows.Threading;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for a worker that manages the lifecycle and display of a WPF window.
    /// </summary>
    /// <typeparam name="TWindow">The type of the window managed by this worker, which must derive from <see cref="System.Windows.Window"/>.</typeparam>
    public abstract class WindowWorker<TWindow> : VisualWorker where TWindow : System.Windows.Window
    {
        protected TWindow? window;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowWorker{TWindow}"/> class.
        /// </summary>
        public WindowWorker()
         : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowWorker{TWindow}"/> class with a specified window.
        /// </summary>
        /// <param name="window">The window instance to be managed by this worker.</param>
        public WindowWorker(TWindow? window)
            : base()
        {
            this.window = window;

            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        /// <summary>
        /// Gets or sets the owner of the managed window.
        /// </summary>
        /// <value>The <see cref="System.Windows.Window"/> that owns the managed window, or <see langword="null"/> if no owner is set.</value>
        public System.Windows.Window? Owner
        {
            get
            {
                return window?.Owner;
            }

            set
            {
                if (window is null)
                {
                    return;
                }

                window.Owner = value;
            }
        }

        /// <summary>
        /// Executes the worker's logic and invokes the display of the managed window on the UI thread.
        /// </summary>
        public override void Run()
        {
            base.Run();

            if (window is null)
            {
                return;
            }

            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                window.Show();
            });
        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (window is null)
            {
                return;
            }

            // Close the ProgressBarWindow on the UI thread
            window.Dispatcher.Invoke(() =>
            {
                window.Close();
            });
        }
    }
}