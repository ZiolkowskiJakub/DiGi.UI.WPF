namespace DiGi.UI.WPF.Core.Constants
{
    public static class FileFilter
    {
        public static DiGi.Core.IO.Classes.FileFilter Jpeg { get; } = DiGi.Core.IO.Create.FileFilter(FileTypeName.Jpeg, FileExtension.Jpeg_1, FileExtension.Jpeg_2, FileExtension.Jpeg_3, FileExtension.Jpeg_4);
        public static DiGi.Core.IO.Classes.FileFilter Png { get; } = DiGi.Core.IO.Create.FileFilter(FileTypeName.Png, FileExtension.Png);
    }
}
