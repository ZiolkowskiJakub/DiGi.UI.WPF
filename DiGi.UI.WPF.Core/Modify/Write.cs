using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Imaging;

namespace DiGi.UI.WPF.Core
{
    public static partial class Modify
    {
        public static bool Write(BitmapImage bitmapImage, string path)
        {
            if(bitmapImage == null)
            {
                return false;
            }

            BitmapEncoder bitmapEncoder = Query.BitmapEncoder(Query.FileFilter(path));
            if(bitmapEncoder == null)
            {
                bitmapEncoder = new PngBitmapEncoder();
            }

            bitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapImage));

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                bitmapEncoder.Save(fileStream);
            }

            return true;
        }

        public static bool Write(BitmapImage bitmapImage, out string path)
        {
            path = null;

            if(bitmapImage == null)
            {
                return false;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = DiGi.Core.IO.Query.Filter(Constants.FileFilter.Jpeg, Constants.FileFilter.Png, DiGi.Core.IO.Create.FileFilter_AllFiles());
            bool? show = saveFileDialog.ShowDialog();
            if (show == null || !show.HasValue || !show.Value)
            {
                return false;
            }

            path = saveFileDialog.FileName;

            return Write(bitmapImage, path);
        }

        public static bool Write(BitmapImage bitmapImage)
        {
            return Write(bitmapImage, out string path);
        }
    }
}