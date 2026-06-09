using DiGi.UI.WPF.Classes;

namespace DiGi.UI.WPF.Delegates
{
    /// <summary>
    /// Represents the method that will handle a cancelling event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="CancellingEventArgs"/> that contains the event data.</param>
    public delegate void CancellingEventHandler(object sender, CancellingEventArgs e);
}