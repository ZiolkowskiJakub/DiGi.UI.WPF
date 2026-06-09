using DiGi.UI.WPF.Delegates;
using System.Windows;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for CheckBoxTreeViewWindow.xaml
    /// </summary>
    public partial class CheckBoxTreeViewWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxTreeViewWindow"/> class with a specified title.
        /// </summary>
        /// <param name="title">The title to be displayed on the window.</param>
        public CheckBoxTreeViewWindow(string? title)
        {
            InitializeComponent();

            CheckBoxTreeViewControl_Main.ItemAdding += CheckBoxTreeViewControl_Main_ItemAdding;

            Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxTreeViewWindow"/> class.
        /// </summary>
        public CheckBoxTreeViewWindow()
            : this(null)
        {
        }

        /// <summary>
        /// Occurs when an item is being added to the tree view control.
        /// </summary>
        public event CheckBoxTreeViewItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Collapses all nodes within the tree view control.
        /// </summary>
        public void CollapseAll()
        {
            CheckBoxTreeViewControl_Main.CollapseAll();
        }

        /// <summary>
        /// Expands all nodes within the tree view control.
        /// </summary>
        public void ExpandAll()
        {
            CheckBoxTreeViewControl_Main.ExpandaAll();
        }

        /// <summary>
        /// Retrieves a list of items from the tree view control.
        /// </summary>
        /// <typeparam name="T">The type of items to retrieve.</typeparam>
        /// <param name="selected">If set to <c>true</c>, only selected items are returned; otherwise, all items are returned.</param>
        /// <returns>A list of items of type <typeparamref name="T"/>, or <c>null</c> if no items are found.</returns>
        public List<T>? GetItems<T>(bool selected = true)
        {
            return CheckBoxTreeViewControl_Main.GetItems<T>(selected);
        }

        /// <summary>
        /// Sets the items to be displayed in the tree view control.
        /// </summary>
        /// <typeparam name="T">The type of items to set.</typeparam>
        /// <param name="values">An enumerable collection of items to populate the tree view.</param>
        public void SetItems<T>(IEnumerable<T> values)
        {
            CheckBoxTreeViewControl_Main.SetItems(values);
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