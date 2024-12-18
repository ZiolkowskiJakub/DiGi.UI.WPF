namespace DiGi.UI.WPF.Core.Classes
{
    public class CheckBoxTreeViewItemAddingEventArgs : TreeViewItemAddingEventArgs
    {
        private bool? isChecked;

        public CheckBoxTreeViewItemAddingEventArgs(object item)
            : base(item)
        {

        }

        public bool? IsChecked
        {
            get
            {
                return isChecked;
            }

            set
            {
                isChecked = value;
                handled = true;
            }
        }
    }
}
