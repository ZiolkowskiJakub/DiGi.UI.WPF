using DiGi.UI.WPF.Classes;

namespace DiGi.UI.WPF.Delegates
{
    /// <summary>
    /// Represents the method that will handle the event when an item is being added to a ListBox.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="ListBoxItemAddingEventArgs"/> that contains the event data.</param>
    public delegate void ListBoxItemAddingEventHandler(object sender, ListBoxItemAddingEventArgs e);
}