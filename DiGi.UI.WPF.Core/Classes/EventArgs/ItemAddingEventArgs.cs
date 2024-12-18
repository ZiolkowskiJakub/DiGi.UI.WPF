using System;

namespace DiGi.UI.WPF.Core.Classes
{
    public abstract class ItemAddingEventArgs : EventArgs
    {
        protected bool handled = false;
       
        private string? name = null;
        
        public ItemAddingEventArgs(object item)
        {
            Item = item;
        }

        public bool Handled
        {
            get
            {
                return handled;
            }

        }

        public object Item { get; }
        
        public string? Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                handled = true;
            }
        }
    }
}
