using DiGi.UI.WPF.Classes;

namespace DiGi.UI.WPF.Delegates
{
    /// <summary>
    /// Represents the method that will handle the event when a TreeView item is being added.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="TreeViewItemAddingEventArgs"/> that contains the event data.</param>
    public delegate void TreeViewItemAddingEventHandler(object sender, TreeViewItemAddingEventArgs e);
}