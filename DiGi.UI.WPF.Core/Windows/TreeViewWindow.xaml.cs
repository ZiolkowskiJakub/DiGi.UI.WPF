using DiGi.UI.WPF.Core.Delegates;
using System.Windows;


namespace DiGi.UI.WPF.Core.Windows
{
    /// <summary>
    /// Interaction logic for TreeViewWindow.xaml
    /// </summary>
    public partial class TreeViewWindow : Window
    {
        public TreeViewWindow(string? title)
        {
            InitializeComponent();

            TreeViewControl_Main.ItemAdding += TreeViewControl_Main_ItemAdding;

            Title = title;
        }

        public TreeViewWindow()
            : this(null)
        {

        }

        public event TreeViewItemAddingEventHandler ItemAdding;
        
        public void CollapseAll()
        {
            TreeViewControl_Main.CollapseAll();
        }

        public void ExpandAll()
        {
            TreeViewControl_Main.ExpandaAll();
        }

        public List<T> GetItems<T>(bool selected = true)
        {
            return TreeViewControl_Main.GetItems<T>(selected);
        }

        public void SetItems<T>(IEnumerable<T> values)
        {
            TreeViewControl_Main.SetItems<T>(values);
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void TreeViewControl_Main_ItemAdding(object sender, Classes.TreeViewItemAddingEventArgs e)
        {
            ItemAdding?.Invoke(this, e);
        }
    }
}
