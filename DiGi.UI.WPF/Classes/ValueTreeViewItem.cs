using System.Windows.Controls;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Represents a tree view item that encapsulates an underlying value.
    /// </summary>
    public class ValueTreeViewItem : TreeViewItem
    {
        private readonly object? value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTreeViewItem"/> class with the specified value.
        /// </summary>
        /// <param name="value">The underlying value to be associated with this tree view item.</param>
        public ValueTreeViewItem(object? value)
            : base()
        {
            this.value = value;
        }

        /// <summary>
        /// Gets the underlying value associated with this tree view item.
        /// </summary>
        public object? Value
        {
            get
            {
                return value;
            }
        }
    }
}