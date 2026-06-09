using System.Windows.Controls;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Represents a <see cref="TreeViewItem"/> that is associated with a specific <see cref="ItemPath"/>.
    /// </summary>
    public class ItemPathTreeViewItem : TreeViewItem
    {
        private readonly ItemPath? itemPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPathTreeViewItem"/> class.
        /// </summary>
        /// <param name="itemPath">The <see cref="ItemPath"/> associated with this tree view item.</param>
        public ItemPathTreeViewItem(ItemPath itemPath)
            : base()
        {
            this.itemPath = itemPath;
        }

        /// <summary>
        /// Gets the <see cref="ItemPath"/> associated with this tree view item.
        /// </summary>
        public ItemPath? ItemPath
        {
            get
            {
                return itemPath;
            }
        }
    }
}