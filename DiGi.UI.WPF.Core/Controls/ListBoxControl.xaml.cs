using DiGi.UI.WPF.Core.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Controls
{
    /// <summary>
    /// Interaction logic for ListBoxControl.xaml
    /// </summary>
    public partial class ListBoxControl : UserControl, IControl
    {
        public ListBoxControl()
        {
            InitializeComponent();
            SetEnabled();
        }

        public event SelectionChangedEventHandler SelectionChanged;
       
        public SelectionMode SelectionMode
        {
            get
            {
                return ListBox_Main.SelectionMode;
            }

            set
            {
                ListBox_Main.SelectionMode = value;
                SetEnabled();
            }
        }

        public List<T> GetValues<T>(bool selected = true)
        {
            System.Collections.IList list = selected ? ListBox_Main.SelectedItems : ListBox_Main.Items;

            List<T> result = new List<T>();
            foreach (ListBoxItem listBoxItem in list)
            {
                object @object = listBoxItem?.Tag;
                if (@object is T)
                {
                    result.Add((T)@object);
                }
            }

            return result;
        }

        public void SetValues<T>(IEnumerable<T> values, Func<T, string> func = null)
        {
            ListBox_Main.Items.Clear();

            if (values == null)
            {
                return;
            }

            foreach (T value in values)
            {
                string text = func == null ? null : func.Invoke(value);
                ListBox_Main.Items.Add(new ListBoxItem() { Content = text, Tag = value });
            }
        }

        private void Button_SelectAll_Click(object sender, RoutedEventArgs e)
        {
            SelectAll();
        }

        private void Button_SelectNone_Click(object sender, RoutedEventArgs e)
        {
            SelectNone();
        }

        private void ListBox_Main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        private void SelectAll()
        {
            ListBox_Main.SelectionChanged -= ListBox_Main_SelectionChanged;
            for (int i = 0; i < ListBox_Main.Items.Count - 1; i++)
            {
                ListBox_Main.SelectedItems.Add(ListBox_Main.Items[i]);
            }
            ListBox_Main.SelectionChanged += ListBox_Main_SelectionChanged;

            if (ListBox_Main.Items.Count != 0)
            {
                ListBox_Main.SelectedItems.Add(ListBox_Main.Items[ListBox_Main.Items.Count - 1]);
            }
        }

        private void SelectNone()
        {
            ListBox_Main.SelectedItems.Clear();
        }
        
        private void SetEnabled()
        {
            Button_SelectAll.IsEnabled = ListBox_Main.SelectionMode != SelectionMode.Single;
        }
    }
}
