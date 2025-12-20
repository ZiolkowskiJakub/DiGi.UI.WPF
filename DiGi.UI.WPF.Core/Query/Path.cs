using Microsoft.Win32;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static string? Path(this System.Windows.Window? window, string fileTypeName, string fileExtension)
        {
            OpenFileDialog openFileDialog = new ()
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

        public static string? Path(this System.Windows.Window? window, DiGi.Core.IO.Classes.FileFilter? fileFilter = null, bool allFiles = false)
        {
            List<DiGi.Core.IO.Classes.FileFilter> fileFilters = [];
            if (fileFilter == null)
            {
                fileFilters.Add(DiGi.Core.IO.Create.FileFilter_AllFiles());
            }
            else
            {
                fileFilters.Add(fileFilter);
                if(allFiles)
                {
                    fileFilters.Add(DiGi.Core.IO.Create.FileFilter_AllFiles());
                }
            }

            OpenFileDialog openFileDialog = new ()
            {
                Title = string.Format("Select {0}", fileFilter?.Name),
                Filter = DiGi.Core.IO.Query.Filter(fileFilters?.ToArray()),
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

        public static string? Path(this System.Windows.Window? window, string? title, IEnumerable<DiGi.Core.IO.Classes.FileFilter>? fileFilters)
        {
            OpenFileDialog openFileDialog = new ()
            {
                Title = title ?? "Select file",
                Filter = DiGi.Core.IO.Query.Filter(fileFilters?.ToArray()),
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