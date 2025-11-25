using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Classes
{
    public class ItemPathTreeViewItem : TreeViewItem
    {
        private readonly ItemPath? itemPath;

        public ItemPathTreeViewItem(ItemPath itemPath)
            : base()
        {
            this.itemPath = itemPath;
        }

        public ItemPath? ItemPath
        {
            get
            {
                return itemPath;
            }
        }
    }
}
