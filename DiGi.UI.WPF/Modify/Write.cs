using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Imaging;

namespace DiGi.UI.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Writes the specified bitmap image to a file at the given path.
        /// </summary>
        /// <param name="bitmapImage">The bitmap image to save.</param>
        /// <param name="path">The destination file path.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(BitmapImage? bitmapImage, string? path)
        {
            if (bitmapImage == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            BitmapEncoder? bitmapEncoder = Query.BitmapEncoder(Query.FileFilter(path));
            bitmapEncoder ??= new PngBitmapEncoder();

            bitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapImage));

            using FileStream fileStream = new(path, FileMode.Create);

            bitmapEncoder.Save(fileStream);

            return true;
        }

        /// <summary>
        /// Writes the specified bitmap image to a file using a save file dialog to determine the destination path.
        /// </summary>
        /// <param name="bitmapImage">The bitmap image to save.</param>
        /// <param name="path">When this method returns, contains the path of the file that was saved, or null if the operation failed.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(BitmapImage? bitmapImage, out string? path)
        {
            path = null;

            if (bitmapImage == null)
            {
                return false;
            }

            SaveFileDialog saveFileDialog = new()
            {
                Filter = DiGi.Core.IO.Query.Filter(Constants.FileFilter.Jpeg, Constants.FileFilter.Png, DiGi.Core.IO.Create.FileFilter_AllFiles())
            };
            bool? show = saveFileDialog.ShowDialog();
            if (show == null || !show.HasValue || !show.Value)
            {
                return false;
            }

            path = saveFileDialog.FileName;

            return Write(bitmapImage, path);
        }

        /// <summary>
        /// Writes the specified bitmap image to a file using a save file dialog.
        /// </summary>
        /// <param name="bitmapImage">The bitmap image to save.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(BitmapImage? bitmapImage)
        {
            return Write(bitmapImage, out _);
        }
    }
}