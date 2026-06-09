using System.Windows.Controls;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for a worker that manages a specific type of WPF control.
    /// </summary>
    /// <typeparam name="TControl">The type of the WPF control this worker operates on, which must derive from <see cref="Control"/>.</typeparam>
    public abstract class ControlWorker<TControl> : VisualWorker where TControl : Control
    {
        /// <summary>
        /// The reference to the WPF control instance managed by this worker.
        /// </summary>
        protected TControl control;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlWorker{TControl}"/> class.
        /// </summary>
        /// <param name="control">The <see cref="Control"/> instance to be associated with this worker.</param>
        public ControlWorker(TControl control)
            : base()
        {
            this.control = control;
        }
    }
}