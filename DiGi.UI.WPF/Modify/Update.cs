using DiGi.UI.WPF.Classes;
using System.Windows.Controls;

namespace DiGi.UI.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Updates or creates a tree view item based on the provided path within an item collection.
        /// </summary>
        /// <param name="itemCollection">The collection of items to search or update.</param>
        /// <param name="path">The target path for the tree view item.</param>
        /// <param name="createFunc">A function used to create a new tree view item if it does not exist at the specified path.</param>
        /// <returns>The updated or created <see cref="ItemPathTreeViewItem"/>, or <c>null</c> if the operation failed or inputs were null.</returns>
        public static ItemPathTreeViewItem? Update(this ItemCollection? itemCollection, ItemPath? path, Func<ItemPath?, ItemPathTreeViewItem?>? createFunc)
        {
            return Update(itemCollection, path, createFunc, null);
        }

        /// <summary>
        /// Updates or creates a tree view item based on the provided path within an item collection, optionally specifying a parent path for recursive traversal.
        /// </summary>
        /// <param name="itemCollection">The collection of items to search or update.</param>
        /// <param name="path">The target path for the tree view item.</param>
        /// <param name="createFunc">A function used to create a new tree view item if it does not exist at the specified path.</param>
        /// <param name="parentPath">The path of the parent item, used during recursive updates to track depth and hierarchy.</param>
        /// <returns>The updated or created <see cref="ItemPathTreeViewItem"/>, or <c>null</c> if the operation failed or inputs were null.</returns>
        public static ItemPathTreeViewItem? Update(this ItemCollection? itemCollection, ItemPath? path, Func<ItemPath?, ItemPathTreeViewItem?>? createFunc, ItemPath? parentPath)
        {
            if (itemCollection == null || path == null || createFunc == null)
            {
                return null;
            }

            List<string> names = path.GetNames();
            if (names == null || names.Count == 0)
            {
                return null;
            }

            List<string>? parentNames = parentPath?.GetNames();
            if (parentNames != null && parentNames.Count >= names.Count)
            {
                return null;
            }

            Func<ItemPathTreeViewItem?, ItemPath?, bool> matchFunc = new((itemPathTreeViewItem, itemPath) =>
            {
                if (itemPathTreeViewItem == null || itemPath == null)
                {
                    return false;
                }

                if (itemPathTreeViewItem.ItemPath is not ItemPath itemPath_TreeViewItem)
                {
                    return false;
                }

                List<string> names = itemPath.GetNames();
                List<string> names_TreeViewItem = itemPath_TreeViewItem.GetNames();

                if (names_TreeViewItem.Count > names.Count)
                {
                    return false;
                }

                for (int i = 0; i < names_TreeViewItem.Count; i++)
                {
                    if (names_TreeViewItem[i] != names[i])
                    {
                        return false;
                    }
                }

                return true;
            });

            ItemPathTreeViewItem? itemPathTreeViewItem;
            ItemPath? path_Temp;

            foreach (object @object in itemCollection)
            {
                itemPathTreeViewItem = @object as ItemPathTreeViewItem;
                if (itemPathTreeViewItem == null)
                {
                    continue;
                }

                if (matchFunc.Invoke(itemPathTreeViewItem, path))
                {
                    path_Temp = itemPathTreeViewItem.ItemPath;
                    if (path_Temp is not null && path.Equals(path_Temp))
                    {
                        return itemPathTreeViewItem;
                    }

                    return Update(itemPathTreeViewItem.Items, path, createFunc, path_Temp);
                }
            }

            if (parentPath is null)
            {
                path_Temp = new ItemPath(names[0]);
            }
            else
            {
                path_Temp = new ItemPath(names.GetRange(0, parentPath.GetNames().Count + 1));
            }

            itemPathTreeViewItem = createFunc.Invoke(path_Temp);
            if (itemPathTreeViewItem == null)
            {
                return null;
            }

            itemCollection.Add(itemPathTreeViewItem);
            if (path.Equals(path_Temp))
            {
                return itemPathTreeViewItem;
            }

            return Update(itemPathTreeViewItem.Items, path, createFunc, path_Temp);
        }
    }
}