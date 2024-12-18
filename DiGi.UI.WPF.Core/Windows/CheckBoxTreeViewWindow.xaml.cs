using DiGi.UI.WPF.Core.Delegates;
using System.Windows;

namespace DiGi.UI.WPF.Core.Windows
{
    /// <summary>
    /// Interaction logic for CheckBoxTreeViewWindow.xaml
    /// </summary>
    public partial class CheckBoxTreeViewWindow : Window
    {
        public CheckBoxTreeViewWindow(string? title)
        {
            InitializeComponent();

            CheckBoxTreeViewControl_Main.ItemAdding += CheckBoxTreeViewControl_Main_ItemAdding;

            Title = title;
        }

        public CheckBoxTreeViewWindow()
            : this(null)
        {

        }

        public event CheckBoxTreeViewItemAddingEventHandler ItemAdding;
        
        public void CollapseAll()
        {
            CheckBoxTreeViewControl_Main.CollapseAll();
        }

        public void ExpandAll()
        {
            CheckBoxTreeViewControl_Main.ExpandaAll();
        }

        public List<T>? GetItems<T>(bool selected = true)
        {
            return CheckBoxTreeViewControl_Main.GetItems<T>(selected);
        }

        public void SetItems<T>(IEnumerable<T> values)
        {
            CheckBoxTreeViewControl_Main.SetItems<T>(values);
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CheckBoxTreeViewControl_Main_ItemAdding(object sender, Classes.CheckBoxTreeViewItemAddingEventArgs e)
        {
            ItemAdding?.Invoke(this, e);
        }
    }
}
