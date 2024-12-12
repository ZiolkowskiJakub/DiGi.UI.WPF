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
        }

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

        public List<T> GetValues<T>(bool selected = true)
        {
            return ListBoxControl_Main.GetValues<T>(selected);
        }

        public void SetValues<T>(IEnumerable<T> values, Func<T, string> func = null)
        {
            ListBoxControl_Main.SetValues<T>(values, func);
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ListBoxControl_Main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }
    }
}
