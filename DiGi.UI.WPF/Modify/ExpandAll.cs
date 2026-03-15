using System.Windows.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Modify
    {
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