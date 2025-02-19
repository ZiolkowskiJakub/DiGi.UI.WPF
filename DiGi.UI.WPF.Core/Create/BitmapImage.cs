using System.IO;
using System.Windows.Media.Imaging;

namespace DiGi.UI.WPF.Core
{
    public static partial class Create
    {
        public static BitmapImage BitmapImage(this byte[] bytes)
        {
            if(bytes == null)
            {
                return null;
            }

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BitmapImage result = new BitmapImage();
                result.BeginInit();
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = memoryStream;
                result.EndInit();
                result.Freeze();
                return result;
            }
        }

        public static BitmapImage BitmapImage(System.Drawing.Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                memoryStream.Position = 0;

                BitmapImage result = new BitmapImage();
                result.BeginInit();
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = memoryStream;
                result.EndInit();
                result.Freeze();

                return result;
            }
        }
    }
}
