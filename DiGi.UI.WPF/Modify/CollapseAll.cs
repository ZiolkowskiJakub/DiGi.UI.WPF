using System.Windows.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Collapses all items in the specified item collection.
        /// </summary>
        /// <param name="itemCollection">The <see cref="ItemCollection"/> to collapse.</param>
        /// <param name="inverse">A boolean value indicating whether to invert the operation (expand instead of collapse).</param>
        public static void CollapseAll(this ItemCollection itemCollection, bool inverse = false)
        {
            ExpandAll(itemCollection, !inverse);
        }
    }
}