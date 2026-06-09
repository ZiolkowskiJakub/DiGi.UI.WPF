using System.Windows.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Recursively expands or collapses all items within the specified <see cref="ItemCollection"/>.
        /// </summary>
        /// <param name="itemCollection">The collection of items to be expanded or collapsed.</param>
        /// <param name="inverse">If set to <c>true</c>, all items will be collapsed instead of expanded. Defaults to <c>false</c>.</param>
        public static void ExpandAll(this ItemCollection itemCollection, bool inverse = false)
        {
            if (itemCollection == null)
            {
                return;
            }

            foreach (object @object in itemCollection)
            {
                if (@object is not TreeViewItem treeViewItem)
                {
                    continue;
                }

                treeViewItem.IsExpanded = !inverse;
                ExpandAll(treeViewItem.Items, inverse);
            }
        }
    }
}