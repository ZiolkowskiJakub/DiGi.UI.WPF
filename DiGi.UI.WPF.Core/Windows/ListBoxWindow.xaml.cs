using DiGi.UI.WPF.Core.Delegates;
using DiGi.UI.WPF.Core.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Windows
{
    /// <summary>
    /// Interaction logic for ListBoxWindow.xaml
    /// </summary>
    public partial class ListBoxWindow : Window, IWindow
    {
        public ListBoxWindow(string title)
            : this()
        {
            Title = title;
        }

        public ListBoxWindow()
        {
            InitializeComponent();

            ListBoxControl_Main.SelectionChanged += ListBoxControl_Main_SelectionChanged;
            ListBoxControl_Main.ItemAdding += ListBoxControl_Main_ItemAdding;
        }

        
        public event ListBoxItemAddingEventHandler ItemAdding;

        
        public event SelectionChangedEventHandler SelectionChanged;

        public SelectionMode SelectionMode
        {
            get
            {
                return ListBoxControl_Main.SelectionMode;
            }

            set
            {
                ListBoxControl_Main.SelectionMode = value;
            }
        }

        public List<T> GetItems<T>(bool selected = true)
        {
            return ListBoxControl_Main.GetItems<T>(selected);
        }

        public void SetItems<T>(IEnumerable<T> values)
        {
            ListBoxControl_Main.SetItems<T>(values);
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ListBoxControl_Main_ItemAdding(object sender, Classes.ListBoxItemAddingEventArgs e)
        {
            ItemAdding?.Invoke(this, e);
        }
        
        private void ListBoxControl_Main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }
    }
}
