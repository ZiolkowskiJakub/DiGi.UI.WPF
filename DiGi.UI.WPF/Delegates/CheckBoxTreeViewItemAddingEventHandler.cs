using DiGi.UI.WPF.Classes;

namespace DiGi.UI.WPF.Delegates
{
    /// <summary>
    /// Represents the method that will handle the event when a CheckBoxTreeViewItem is being added.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="CheckBoxTreeViewItemAddingEventArgs"/> that contains the event data.</param>
    public delegate void CheckBoxTreeViewItemAddingEventHandler(object sender, CheckBoxTreeViewItemAddingEventArgs e);
}