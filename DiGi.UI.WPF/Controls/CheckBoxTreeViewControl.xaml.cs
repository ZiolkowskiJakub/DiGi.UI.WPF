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
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxTreeViewControl"/> class.
        /// </summary>
        public CheckBoxTreeViewControl()
            : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when an item is being added to the tree view, allowing for customization of the item's path and name.
        /// </summary>
        public event CheckBoxTreeViewItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Collapses all nodes within the tree view.
        /// </summary>
        public void CollapseAll()
        {
            Modify.CollapseAll(TreeView_Main.Items);
        }

        /// <summary>
        /// Expands all nodes within the tree view.
        /// </summary>
        public void ExpandaAll()
        {
            Modify.ExpandAll(TreeView_Main.Items);
        }

        /// <summary>
        /// Retrieves a list of items of type <typeparamref name="T"/> from the tree view, optionally filtered by their selection state.
        /// </summary>
        /// <typeparam name="T">The type of items to retrieve.</typeparam>
        /// <param name="selected">A boolean indicating whether only selected items should be returned. Defaults to <c>true</c>.</param>
        /// <returns>A list of items of type <typeparamref name="T"/>, or <c>null</c> if no matching items are found.</returns>
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

        /// <summary>
        /// Populates the tree view with a collection of items.
        /// </summary>
        /// <typeparam name="T">The type of values to be added to the tree view.</typeparam>
        /// <param name="values">An enumerable collection of values to populate the control.</param>
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