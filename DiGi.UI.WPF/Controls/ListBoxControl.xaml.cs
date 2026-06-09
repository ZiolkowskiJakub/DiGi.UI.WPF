using DiGi.UI.WPF.Classes;
using DiGi.UI.WPF.Delegates;
using DiGi.UI.WPF.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for ListBoxControl.xaml
    /// </summary>
    public partial class ListBoxControl : UserControl, IControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxControl"/> class.
        /// </summary>
        public ListBoxControl()
        {
            InitializeComponent();
            SetEnabled();
        }

        /// <summary>
        /// Occurs when an item is about to be added to the list box.
        /// </summary>
        public event ListBoxItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Occurs when the selection within the list box changes.
        /// </summary>
        public event SelectionChangedEventHandler? SelectionChanged;

        /// <summary>
        /// Gets or sets the <see cref="SelectionMode"/> of the list box.
        /// </summary>
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

        /// <summary>
        /// Clears all items from the list box.
        /// </summary>
        public void ClearItems()
        {
            ListBox_Main.Items.Clear();
        }

        /// <summary>
        /// Retrieves a list of items of type <typeparamref name="T"/> from the list box.
        /// </summary>
        /// <typeparam name="T">The type of items to retrieve.</typeparam>
        /// <param name="selected">If set to <c>true</c>, only selected items are returned; otherwise, all items are returned.</param>
        /// <returns>A list containing the retrieved items of type <typeparamref name="T"/>, or <c>null</c> if no items match the criteria.</returns>
        public List<T>? GetItems<T>(bool selected = true)
        {
            return Query.TagItems<T, ListBoxItem>(ListBox_Main.Items, true, selected, x => x != null && x.IsSelected);
        }

        /// <summary>
        /// Sets the items in the list box using the provided collection of values.
        /// </summary>
        /// <typeparam name="T">The type of items to be added to the list box.</typeparam>
        /// <param name="values">An enumerable collection of values to populate the list box with.</param>
        public void SetItems<T>(IEnumerable<T> values)
        {
            ListBox_Main.Items.Clear();

            if (values == null)
            {
                return;
            }

            foreach (T value in values)
            {
                ListBoxItemAddingEventArgs itemAddingEventArgs = new(value);
                ItemAdding?.Invoke(this, itemAddingEventArgs);

                string? text = value?.ToString();
                if (itemAddingEventArgs.Handled)
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
                ListBox_Main.SelectedItems.Add(ListBox_Main.Items[^1]);
            }
        }

        private void SelectNone()
        {
            if (SelectionMode == SelectionMode.Single)
            {
                // Single selection mode – use SelectedItem
                ListBox_Main.SelectedItem = null;
            }
            else
            {
                // Multiple or extended selection mode – use SelectedItems
                ListBox_Main.SelectedItems.Clear();
            }
        }

        private void SetEnabled()
        {
            Button_SelectAll.IsEnabled = ListBox_Main.SelectionMode != SelectionMode.Single;
        }
    }
}