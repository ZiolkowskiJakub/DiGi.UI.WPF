using DiGi.UI.WPF.Core.Classes;
using DiGi.UI.WPF.Core.Delegates;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Controls
{
    /// <summary>
    /// Interaction logic for TreeViewControl.xaml
    /// </summary>
    public partial class TreeViewControl : UserControl
    {
        public event TreeViewItemAddingEventHandler ItemAdding;

        public TreeViewControl()
        {
            InitializeComponent();
        }

        public List<T> GetItems<T>(bool selected = true)
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

            Func<TreeViewItem, ItemPath, bool> matchFunc = new Func<TreeViewItem, ItemPath, bool>( (treeViewItem, itemPath) => 
            {
                if(treeViewItem == null || itemPath == null)
                {
                    return false;
                }

                string name = treeViewItem.Header?.ToString();

                return name == itemPath.Name;
            });

            Func<ItemPath, TreeViewItem> createFunc = new Func<ItemPath, TreeViewItem>((itemPath) => 
            {
                if(itemPath == null)
                {
                    return null;
                }

                return new TreeViewItem() { Header = itemPath.Name, Tag = itemPath };
            });

            foreach (T value in values)
            {
                TreeViewItemAddingEventArgs itemAddingEventArgs = new TreeViewItemAddingEventArgs(value);
                ItemAdding?.Invoke(this, itemAddingEventArgs);

                ItemPath path = new ItemPath("Items");
                string name = value?.ToString();
                if (itemAddingEventArgs.Handled)
                {
                    name = itemAddingEventArgs.Name;
                    path = itemAddingEventArgs.Path;
                }

                TreeViewItem treeViewItem = Modify.Update(TreeView_Main.Items, path, matchFunc, createFunc);
                if(treeViewItem == null)
                {
                    continue;
                }


                treeViewItem.Items.Add(new TreeViewItem() { Header = name, Tag = value });
            }
        }

        private void Button_Expand_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Modify.ExpandAll(TreeView_Main.Items);
        }

        private void Button_Collapse_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Modify.CollapseAll(TreeView_Main.Items);
        }

        public void ExpandaAll()
        {
            Modify.ExpandAll(TreeView_Main.Items);
        }

        public void CollapseAll()
        {
            Modify.CollapseAll(TreeView_Main.Items);
        }
    }
}
