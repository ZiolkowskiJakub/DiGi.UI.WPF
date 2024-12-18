using DiGi.UI.WPF.Core.Classes;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core
{
    public static partial class Modify
    {
        public static void ExpandAll(this ItemCollection itemCollection, bool inverse = false)
        {
            if(itemCollection == null)
            {
                return;
            }

            foreach(object @object in itemCollection)
            {
                TreeViewItem? treeViewItem = @object as TreeViewItem;
                if(treeViewItem == null)
                {
                    continue;
                }

                treeViewItem.IsExpanded = !inverse;
                ExpandAll(treeViewItem.Items, inverse);
            }
        }
    }
}