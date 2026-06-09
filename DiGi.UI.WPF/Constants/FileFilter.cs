namespace DiGi.UI.WPF.Constants
{
    /// <summary>
    /// Provides a set of predefined file filters for common image formats used within the WPF user interface.
    /// </summary>
    public static class FileFilter
    {
        /// <summary>
        /// Gets the <see cref="DiGi.Core.IO.Classes.FileFilter"/> configured for JPEG images, encompassing multiple valid JPEG extensions.
        /// </summary>
        public static DiGi.Core.IO.Classes.FileFilter Jpeg { get; } = DiGi.Core.IO.Create.FileFilter(FileTypeName.Jpeg, FileExtension.Jpeg_1, FileExtension.Jpeg_2, FileExtension.Jpeg_3, FileExtension.Jpeg_4);

        /// <summary>
        /// Gets the <see cref="DiGi.Core.IO.Classes.FileFilter"/> configured for PNG images.
        /// </summary>
        public static DiGi.Core.IO.Classes.FileFilter Png { get; } = DiGi.Core.IO.Create.FileFilter(FileTypeName.Png, FileExtension.Png);
    }
}