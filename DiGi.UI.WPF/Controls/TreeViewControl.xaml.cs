using DiGi.UI.WPF.Classes;
using DiGi.UI.WPF.Delegates;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for TreeViewControl.xaml
    /// </summary>
    public partial class TreeViewControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewControl"/> class.
        /// </summary>
        public TreeViewControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when an item is being added to the tree view, allowing for modification of the item's path or name.
        /// </summary>
        public event TreeViewItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Occurs when the selected item in the tree view changes.
        /// </summary>
        public event System.Windows.RoutedPropertyChangedEventHandler<object>? SelectedItemChanged;

        /// <summary>
        /// Clears all items from the main TreeView control.
        /// </summary>
        public void ClearItems()
        {
            TreeView_Main.Items.Clear();
        }

        /// <summary>
        /// Collapses all expandable nodes within the tree view.
        /// </summary>
        public void CollapseAll()
        {
            Modify.CollapseAll(TreeView_Main.Items);
        }

        /// <summary>
        /// Expands all expandable nodes within the tree view.
        /// </summary>
        public void ExpandaAll()
        {
            Modify.ExpandAll(TreeView_Main.Items);
        }

        /// <summary>
        /// Retrieves a list of items of the specified type from the tree view.
        /// </summary>
        /// <typeparam name="T">The type of items to retrieve.</typeparam>
        /// <param name="selected">If set to <c>true</c>, only retrieves items that are currently selected; otherwise, retrieves all items of type <typeparamref name="T"/>.</param>
        /// <returns>A list of items of type <typeparamref name="T"/>, or null if no matching items are found.</returns>
        public List<T>? GetItems<T>(bool selected = true)
        {
            return Query.TagItems<T, TreeViewItem>(TreeView_Main.Items, true, selected, x => x != null && x.IsSelected);
        }

        /// <summary>
        /// Populates the tree view with a collection of values, organizing them by path and allowing custom item creation via the <see cref="ItemAdding"/> event.
        /// </summary>
        /// <typeparam name="T">The type of values to be added to the tree view.</typeparam>
        /// <param name="values">The collection of values to set in the tree view.</param>
        public void SetItems<T>(IEnumerable<T> values)
        {
            TreeView_Main.Items.Clear();

            if (values == null)
            {
                return;
            }

            Func<ItemPath?, ItemPathTreeViewItem?> createFunc = new((itemPath) =>
            {
                if (itemPath == null)
                {
                    return null;
                }

                return new ItemPathTreeViewItem(itemPath) { Header = itemPath.GetNames().Last() };
            });

            foreach (T value in values)
            {
                TreeViewItemAddingEventArgs treeViewItemAddingEventArgs = new(value);
                ItemAdding?.Invoke(this, treeViewItemAddingEventArgs);

                ItemPath? path = new("Items");
                string? name = value?.ToString();
                if (value is ItemPath path_Temp)
                {
                    path = path_Temp;
                    name = null;
                }

                if (treeViewItemAddingEventArgs.Handled)
                {
                    name = treeViewItemAddingEventArgs.Name;
                    path = treeViewItemAddingEventArgs.Path;
                }

                ItemPathTreeViewItem? itemPathTreeViewItem = Modify.Update(TreeView_Main.Items, path, createFunc);
                if (itemPathTreeViewItem != null)
                {
                    itemPathTreeViewItem.Tag = value;
                }

                if (name == null)
                {
                    continue;
                }

                (itemPathTreeViewItem?.Items ?? TreeView_Main.Items).Add(new ValueTreeViewItem(value) { Header = name, Tag = value });
            }
        }

        private void Button_Collapse_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Modify.CollapseAll(TreeView_Main.Items);
        }

        private void Button_Expand_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Modify.ExpandAll(TreeView_Main.Items);
        }

        private void TreeView_Main_SelectedItemChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<object> e)
        {
            SelectedItemChanged?.Invoke(this, e);
        }
    }
}