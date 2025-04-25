using DiGi.Core.IO.Classes;

namespace DiGi.UI.WPF.Core
{
    public static partial class Query
    {
        public static FileFilter FileFilter(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string extension = System.IO.Path.GetExtension(path).ToLower().Trim();
            if (extension.StartsWith("."))
            {
                extension = extension.Substring(1);
            }

            if (Constants.FileFilter.Jpeg.Extensions.Contains(extension))
            {
                return Constants.FileFilter.Jpeg;
            }

            if (Constants.FileFilter.Png.Extensions.Contains(extension))
            {
                return Constants.FileFilter.Png;
            }

            return null;
        }
    }
}