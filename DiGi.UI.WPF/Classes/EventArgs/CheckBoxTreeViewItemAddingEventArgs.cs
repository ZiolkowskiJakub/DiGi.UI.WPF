namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides data for the event that occurs when a check box tree view item is being added.
    /// </summary>
    public class CheckBoxTreeViewItemAddingEventArgs : TreeViewItemAddingEventArgs
    {
        private bool? isChecked;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxTreeViewItemAddingEventArgs"/> class.
        /// </summary>
        /// <param name="item">The item being added to the tree view.</param>
        public CheckBoxTreeViewItemAddingEventArgs(object? item)
            : base(item)
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether the check box associated with the tree view item is checked.
        /// Setting this value marks the event as handled.
        /// </summary>
        public bool? IsChecked
        {
            get
            {
                return isChecked;
            }

            set
            {
                isChecked = value;
                handled = true;
            }
        }
    }
}