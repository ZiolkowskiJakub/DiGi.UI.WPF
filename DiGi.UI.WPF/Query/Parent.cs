using System.Windows.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the parent <see cref="ItemsControl"/> of a given <see cref="System.Windows.DependencyObject"/>.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ItemsControl"/> to return.</typeparam>
        /// <param name="dependencyObject">The dependency object for which to find the parent container.</param>
        /// <returns>The parent <see cref="ItemsControl"/> cast to <typeparamref name="T"/>, or <see langword="null"/> if no such parent exists or the input is null.</returns>
        public static T? Parent<T>(System.Windows.DependencyObject? dependencyObject) where T : ItemsControl
        {
            if (dependencyObject is null)
            {
                return null;
            }

            return ItemsControl.ItemsControlFromItemContainer(dependencyObject) as T;
        }
    }
}