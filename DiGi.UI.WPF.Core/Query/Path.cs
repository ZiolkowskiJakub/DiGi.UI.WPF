using Microsoft.Win32;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static string? Path(this System.Windows.Window window, string fileTypeName, string fileExtension)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = string.Format("Select {0}", fileTypeName),
                Filter = string.Format("{0} (*.{1})|*.{1}|All Files (*.*)|*.*", fileTypeName, fileExtension),
                FilterIndex = 1,
                Multiselect = false
            };

            bool? result = openFileDialog.ShowDialog(window);
            if (result == null || !result.HasValue || !result.Value)
            {
                return null;
            }

            return openFileDialog.FileName;
        }
    }
}