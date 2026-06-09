using DiGi.Core;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides data for events that occur when an item is being added to a tree view.
    /// </summary>
    public class TreeViewItemAddingEventArgs : ItemAddingEventArgs
    {
        private ItemPath? path;

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewItemAddingEventArgs"/> class.
        /// </summary>
        /// <param name="item">The item that is being added to the tree view.</param>
        public TreeViewItemAddingEventArgs(object? item)
            : base(item)
        {
        }

        /// <summary>
        /// Gets or sets the path associated with the tree view item. 
        /// Setting this property creates a clone of the provided path and marks the event as handled.
        /// </summary>
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