using DiGi.UI.WPF.Delegates;
using System.Windows;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for TreeViewWindow.xaml
    /// </summary>
    public partial class TreeViewWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewWindow"/> class with a specified title.
        /// </summary>
        /// <param name="title">The window title to be displayed.</param>
        public TreeViewWindow(string? title)
        {
            InitializeComponent();

            TreeViewControl_Main.ItemAdding += TreeViewControl_Main_ItemAdding;

            Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewWindow"/> class.
        /// </summary>
        public TreeViewWindow()
            : this(null)
        {
        }

        /// <summary>
        /// Occurs when an item is being added to the tree view control.
        /// </summary>
        public event TreeViewItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Collapses all nodes in the main tree view control.
        /// </summary>
        public void CollapseAll()
        {
            TreeViewControl_Main.CollapseAll();
        }

        /// <summary>
        /// Expands all nodes in the main tree view control.
        /// </summary>
        public void ExpandAll()
        {
            TreeViewControl_Main.ExpandaAll();
        }

        /// <summary>
        /// Retrieves a list of items of type <typeparamref name="T"/> from the tree view.
        /// </summary>
        /// <typeparam name="T">The type of items to retrieve.</typeparam>
        /// <param name="selected">If set to <c>true</c>, only selected items are returned; otherwise, all items are returned.</param>
        /// <returns>A list containing the retrieved items of type <typeparamref name="T"/>, or <c>null</c>.</returns>
        public List<T>? GetItems<T>(bool selected = true)
        {
            return TreeViewControl_Main.GetItems<T>(selected);
        }

        /// <summary>
        /// Sets the items of the tree view to the specified collection.
        /// </summary>
        /// <typeparam name="T">The type of items to set.</typeparam>
        /// <param name="values">The enumerable collection of values to populate the tree view.</param>
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