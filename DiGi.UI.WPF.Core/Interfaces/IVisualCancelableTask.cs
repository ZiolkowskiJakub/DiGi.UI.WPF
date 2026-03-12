using DiGi.Core.Interfaces;
using System.ComponentModel;

namespace DiGi.UI.WPF.Core.Interfaces
{
    public interface IVisualCancelableTask : IWPFObject, ITask, INotifyPropertyChanged, INamedObject, IDescribableObject
    {
    }
}