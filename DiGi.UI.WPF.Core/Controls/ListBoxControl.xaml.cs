using DiGi.UI.WPF.Core.Classes;
using DiGi.UI.WPF.Core.Delegates;
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

        public event ListBoxItemAddingEventHandler ItemAdding;
       
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

        public List<T> GetItems<T>(bool selected = true)
        {
            return Query.TagItems<T, ListBoxItem>(ListBox_Main.Items, true, selected, x => x != null && x.IsSelected);
        }

        public void SetItems<T>(IEnumerable<T> values)
        {
            ListBox_Main.Items.Clear();

            if (values == null)
            {
                return;
            }

            foreach (T value in values)
            {
                ListBoxItemAddingEventArgs itemAddingEventArgs = new ListBoxItemAddingEventArgs(value);
                ItemAdding?.Invoke(this, itemAddingEventArgs);

                string text = value?.ToString();
                if(itemAddingEventArgs.Handled)
                {
                    text = itemAddingEventArgs.Name;
                }

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
