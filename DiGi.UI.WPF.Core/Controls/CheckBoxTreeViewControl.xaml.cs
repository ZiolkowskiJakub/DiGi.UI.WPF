using DiGi.UI.WPF.Core.Classes;
using DiGi.UI.WPF.Core.Delegates;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Controls
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

            Func<TreeViewItem?, ItemPath?, bool> matchFunc = new((treeViewItem, itemPath) =>
            {
                if (treeViewItem == null || itemPath == null)
                {
                    return false;
                }

                string? name = null;
                if (treeViewItem.Header is CheckBox checkBox)
                {
                    name = checkBox.Name;
                }
                else
                {
                    name = treeViewItem.Header?.ToString();
                }

                return name == itemPath.Name;
            });

            Func<ItemPath?, TreeViewItem?> createFunc = new((itemPath) =>
            {
                if (itemPath == null)
                {
                    return null;
                }

                CheckBox checkBox = new () { Content = itemPath.Name };
                checkBox.Unchecked += CheckBox_Updated;
                checkBox.Checked += CheckBox_Updated;

                return new TreeViewItem() { Header = checkBox, Tag = itemPath };
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

                TreeViewItem? treeViewItem = Modify.Update(TreeView_Main.Items, path, matchFunc, createFunc);
                if (treeViewItem == null)
                {
                    continue;
                }

                CheckBox checkBox = new () { Content = name };
                checkBox.Unchecked += CheckBox_Updated;
                checkBox.Checked += CheckBox_Updated;

                treeViewItem.Items.Add(new TreeViewItem() { Header = checkBox, Tag = value });
            }
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

        private void Button_SelectAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_SelectNone_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
