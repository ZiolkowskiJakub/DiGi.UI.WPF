namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides data for events that occur when an item is being added to a <see cref="System.Windows.Controls.ListBox"/>.
    /// </summary>
    public class ListBoxItemAddingEventArgs : ItemAddingEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxItemAddingEventArgs"/> class.
        /// </summary>
        /// <param name="item">The item that is being added to the <see cref="System.Windows.Controls.ListBox"/>.</param>
        public ListBoxItemAddingEventArgs(object? item)
            : base(item)
        {
        }
    }
}