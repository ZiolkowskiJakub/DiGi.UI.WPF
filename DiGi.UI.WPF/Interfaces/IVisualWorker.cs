namespace DiGi.UI.WPF.Interfaces
{
    /// <summary>
    /// Defines a contract for a visual worker that combines the properties of a WPF object with the operational capabilities of a worker.
    /// </summary>
    public interface IVisualWorker : IWPFObject, DiGi.Core.Interfaces.IWorker
    {
    }
}