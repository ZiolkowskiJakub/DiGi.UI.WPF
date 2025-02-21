using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DiGi.UI.WPF.Core
{
    public static partial class Create
    {
        public static BitmapImage BitmapImage(this byte[] bytes)
        {
            if (bytes == null)
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

        public static BitmapImage BitmapImage(int width, int height, System.Drawing.Color color)
        {
            WriteableBitmap bitmap = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, null);

            // Create pixel data (BGRA format, 4 bytes per pixel)
            int stride = width * 4; // 4 bytes per pixel
            byte[] pixels = new byte[height * stride];

            // Fill with white (BGRA: 255,255,255,255)
            for (int i = 0; i < pixels.Length; i += 4)
            {
                pixels[i] = color.B;     // Blue
                pixels[i + 1] = color.G; // Green
                pixels[i + 2] = color.R; // Red
                pixels[i + 3] = color.A; // Alpha (fully opaque)
            }

            // Write pixels to the bitmap
            bitmap.WritePixels(new Int32Rect(0, 0, width, height), pixels, stride, 0);

            using (var stream = new MemoryStream())
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                encoder.Save(stream);

                BitmapImage result = new BitmapImage();
                result.BeginInit();
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = new MemoryStream(stream.ToArray());
                result.EndInit();
                result.Freeze();

                return result;
            }

        }
    }
}
