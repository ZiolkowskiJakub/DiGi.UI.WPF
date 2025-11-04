using System.Windows.Controls;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static T? Parent<T>(System.Windows.DependencyObject? dependencyObject) where T : ItemsControl
        {
            if(dependencyObject is null)
            {
                return null;
            }

            return ItemsControl.ItemsControlFromItemContainer(dependencyObject) as T;
        }
    }
}