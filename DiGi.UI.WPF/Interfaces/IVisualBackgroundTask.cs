using DiGi.Core.Interfaces;
using System.ComponentModel;

namespace DiGi.UI.WPF.Interfaces
{
    /// <summary>
    /// Defines a contract for a background task that provides visual updates or interactions within the WPF user interface.
    /// </summary>
    public interface IVisualBackgroundTask : IWPFObject, INotifyPropertyChanged, INamedObject, IDescribableObject
    {
        /// <summary>
        /// Gets the name of the type associated with this visual background task.
        /// </summary>
        string? TypeName { get; }

        /// <summary>
        /// Starts the execution of the visual background task.
        /// </summary>
        void Start();
    }
}