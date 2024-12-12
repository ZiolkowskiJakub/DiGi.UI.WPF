using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Classes
{
    public abstract class ControlWorker<TControl> : VisualWorker where TControl : Control
    {
        protected TControl control;

        public ControlWorker(TControl control)
            :base()
        {
            this.control = control;
        }
    }
}