using DiGi.UI.WPF.Delegates;
using DiGi.UI.WPF.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for ListBoxWindow.xaml
    /// </summary>
    public partial class ListBoxWindow : Window, IWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxWindow"/> class with a specified title.
        /// </summary>
        /// <param name="title">The text to be displayed as the window title.</param>
        public ListBoxWindow(string title)
            : this()
        {
            Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxWindow"/> class.
        /// </summary>
        public ListBoxWindow()
        {
            InitializeComponent();

            ListBoxControl_Main.SelectionChanged += ListBoxControl_Main_SelectionChanged;
            ListBoxControl_Main.ItemAdding += ListBoxControl_Main_ItemAdding;
        }

        /// <summary>
        /// Occurs when an item is being added to the internal list box control.
        /// </summary>
        public event ListBoxItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Occurs when the selection within the internal list box control changes.
        /// </summary>
        public event SelectionChangedEventHandler? SelectionChanged;

        /// <summary>
        /// Gets or sets the selection mode of the internal list box control.
        /// </summary>
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

        /// <summary>
        /// Retrieves a list of items from the internal list box control.
        /// </summary>
        /// <typeparam name="T">The type of the items to retrieve.</typeparam>
        /// <param name="selected">If set to <c>true</c>, only selected items are retrieved; otherwise, all items are retrieved.</param>
        /// <returns>A list containing the items of type <typeparamref name="T"/>, or <c>null</c> if no items are available.</returns>
        public List<T>? GetItems<T>(bool selected = true)
        {
            return ListBoxControl_Main.GetItems<T>(selected);
        }

        /// <summary>
        /// Sets the collection of items for the internal list box control.
        /// </summary>
        /// <typeparam name="T">The type of the items to be set.</typeparam>
        /// <param name="values">An enumerable collection of values to populate the list box.</param>
        public void SetItems<T>(IEnumerable<T> values)
        {
            ListBoxControl_Main.SetItems(values);
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