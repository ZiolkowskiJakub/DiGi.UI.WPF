using System.Windows.Controls;

namespace DiGi.UI.WPF.Core.Classes
{
    public class ValueTreeViewItem : TreeViewItem
    {
        private object? value;

        public ValueTreeViewItem(object? value)
            : base()
        {
            this.value = value;
        }

        public object? Value
        {
            get
            {
                return value;
            }
        }
    }
}
