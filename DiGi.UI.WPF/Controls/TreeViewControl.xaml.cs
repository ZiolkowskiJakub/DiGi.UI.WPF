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
        public TreeViewControl()
        {
            InitializeComponent();
        }

        public event TreeViewItemAddingEventHandler? ItemAdding;

        public event System.Windows.RoutedPropertyChangedEventHandler<object>? SelectedItemChanged;

        public void ClearItems()
        {
            TreeView_Main.Items.Clear();
        }

        public void CollapseAll()
        {
            Modify.CollapseAll(TreeView_Main.Items);
        }

        public void ExpandaAll()
        {
            Modify.ExpandAll(TreeView_Main.Items);
        }

        public List<T>? GetItems<T>(bool selected = true)
        {
            return Query.TagItems<T, TreeViewItem>(TreeView_Main.Items, true, selected, x => x != null && x.IsSelected);
        }

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