using DiGi.UI.WPF.Core.Classes;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core
{
    public static partial class Modify
    {
        public static TreeViewItem? Update(this ItemCollection itemCollection, ItemPath path, Func<TreeViewItem, ItemPath, bool> matchFunc, Func<ItemPath, TreeViewItem> createFunc)
        {
            if (itemCollection == null || path == null || matchFunc == null || createFunc == null)
            {
                return null;
            }

            ItemPath? path_Temp = null;
            TreeViewItem? treeViewItem = null;

            foreach (object @object in itemCollection)
            {
                treeViewItem = @object as TreeViewItem;
                if(treeViewItem == null)
                {
                    continue;
                }

                if (matchFunc.Invoke(treeViewItem, path))
                {
                    path_Temp = path.Path;

                    if (path_Temp == null)
                    {
                        return treeViewItem;
                    }

                    return Update(treeViewItem.Items, path_Temp, matchFunc, createFunc);
                }
            }

            treeViewItem = createFunc.Invoke(path);
            if (treeViewItem == null)
            {
                return null;
            }

            itemCollection.Add(treeViewItem);

            path_Temp = path.Path;

            if (path_Temp == null)
            {
                return treeViewItem;
            }

            return Update(treeViewItem.Items, path_Temp, matchFunc, createFunc);
        }
    }
}