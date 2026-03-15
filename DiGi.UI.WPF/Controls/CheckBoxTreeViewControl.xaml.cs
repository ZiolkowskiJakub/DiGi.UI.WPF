using DiGi.UI.WPF.Classes;
using DiGi.UI.WPF.Delegates;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for CheckBoxTreeViewControl.xaml
    /// </summary>
    public partial class CheckBoxTreeViewControl : UserControl
    {
        public CheckBoxTreeViewControl()
            : base()
        {
            InitializeComponent();
        }

        public event CheckBoxTreeViewItemAddingEventHandler? ItemAdding;

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
            Func<TreeViewItem, bool> selectedFunc = new((treeViewItem) =>
            {
                if (treeViewItem?.Header is not CheckBox checkBox)
                {
                    return false;
                }

                return checkBox.IsChecked != null && checkBox.IsChecked.Value;
            });

            return Query.TagItems<T, TreeViewItem>(TreeView_Main.Items, true, selected, selectedFunc);
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

                CheckBox checkBox = new() { Content = itemPath.GetNames().Last() };
                checkBox.Unchecked += CheckBox_Updated;
                checkBox.Checked += CheckBox_Updated;

                return new ItemPathTreeViewItem(itemPath) { Header = checkBox };
            });

            foreach (T value in values)
            {
                CheckBoxTreeViewItemAddingEventArgs itemAddingEventArgs = new(value);
                ItemAdding?.Invoke(this, itemAddingEventArgs);

                ItemPath? path = new("Items");
                string? name = value?.ToString();
                bool? isChecked = null;
                if (itemAddingEventArgs.Handled)
                {
                    name = itemAddingEventArgs.Name;
                    path = itemAddingEventArgs.Path;
                    isChecked = itemAddingEventArgs.IsChecked;
                }

                ItemPathTreeViewItem? itemPathTreeViewItem = Modify.Update(TreeView_Main.Items, path, createFunc);
                if (itemPathTreeViewItem == null)
                {
                    continue;
                }

                itemPathTreeViewItem.Tag = value;

                if (name == null)
                {
                    continue;
                }

                CheckBox checkBox = new() { Content = name };
                checkBox.Unchecked += CheckBox_Updated;
                checkBox.Checked += CheckBox_Updated;

                itemPathTreeViewItem.Items.Add(new ValueTreeViewItem(value) { Header = checkBox, Tag = value });
            }
        }

        private void Button_SelectAll_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_SelectNone_Click(object sender, RoutedEventArgs e)
        {
        }

        private void CheckBox_Updated(object sender, RoutedEventArgs e)
        {
            if (sender is not CheckBox checkBox)
            {
                return;
            }

            Update(checkBox, checkBox.IsChecked);
        }

        private void Update(CheckBox checkBox, bool? isChecked)
        {
            throw new NotImplementedException();
        }
    }
}