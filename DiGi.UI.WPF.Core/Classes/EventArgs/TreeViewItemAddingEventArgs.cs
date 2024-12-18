using DiGi.Core;

namespace DiGi.UI.WPF.Core.Classes
{
    public class TreeViewItemAddingEventArgs : ItemAddingEventArgs
    {
        private ItemPath? path;

        public TreeViewItemAddingEventArgs(object item)
            : base(item)
        {

        }

        public ItemPath? Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value.Clone<ItemPath>();
                handled = true;
            }
        }
    }
}
