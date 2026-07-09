#### [DiGi\.UI\.WPF](DiGi.UI.WPF.Overview.md 'DiGi\.UI\.WPF\.Overview')

## DiGi\.UI\.WPF Namespace
### Classes

<a name='DiGi.UI.WPF.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.UI.WPF.Create.BitmapImage(int,int,System.Drawing.Color)'></a>

## Create\.BitmapImage\(int, int, Color\) Method

Creates a solid color [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage') with the specified dimensions\.

```csharp
public static System.Windows.Media.Imaging.BitmapImage BitmapImage(int width, int height, System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.UI.WPF.Create.BitmapImage(int,int,System.Drawing.Color).width'></a>

`width` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The width of the resulting image in pixels\.

<a name='DiGi.UI.WPF.Create.BitmapImage(int,int,System.Drawing.Color).height'></a>

`height` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The height of the resulting image in pixels\.

<a name='DiGi.UI.WPF.Create.BitmapImage(int,int,System.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') to fill the image with\.

#### Returns
[System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')  
A [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage') representing a solid color rectangle\.

<a name='DiGi.UI.WPF.Create.BitmapImage(System.Drawing.Image)'></a>

## Create\.BitmapImage\(Image\) Method

Converts a [System\.Drawing\.Image](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image 'System\.Drawing\.Image') object into a [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')\.

```csharp
public static System.Windows.Media.Imaging.BitmapImage? BitmapImage(System.Drawing.Image? image);
```
#### Parameters

<a name='DiGi.UI.WPF.Create.BitmapImage(System.Drawing.Image).image'></a>

`image` [System\.Drawing\.Image](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image 'System\.Drawing\.Image')

The source image to convert\.

#### Returns
[System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')  
A [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage') created from the provided image, or null if the input is null\.

<a name='DiGi.UI.WPF.Create.BitmapImage(thisbyte[])'></a>

## Create\.BitmapImage\(this byte\[\]\) Method

Converts a byte array into a [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')\.

```csharp
public static System.Windows.Media.Imaging.BitmapImage? BitmapImage(this byte[]? bytes);
```
#### Parameters

<a name='DiGi.UI.WPF.Create.BitmapImage(thisbyte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array containing the image data\.

#### Returns
[System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')  
A [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage') created from the provided bytes, or null if the input is null\.

<a name='DiGi.UI.WPF.Create.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string)'></a>

## Create\.VisualBackgroundTask\(IBackgroundTask, string, string\) Method

Creates a visual wrapper for the specified background task, automatically determining if it is reportable to provide the appropriate visual implementation\.

```csharp
public static DiGi.UI.WPF.Interfaces.IVisualBackgroundTask VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask backgroundTask, string name, string description);
```
#### Parameters

<a name='DiGi.UI.WPF.Create.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).backgroundTask'></a>

`backgroundTask` [DiGi\.Core\.Interfaces\.IBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ibackgroundtask 'DiGi\.Core\.Interfaces\.IBackgroundTask')

The background task instance to be wrapped\.

<a name='DiGi.UI.WPF.Create.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the task\.

<a name='DiGi.UI.WPF.Create.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of the task's operation\.

#### Returns
[IVisualBackgroundTask](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask')  
An implementation of [IVisualBackgroundTask](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask') that provides visual tracking for the background task\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [backgroundTask](DiGi.UI.WPF.md#DiGi.UI.WPF.Create.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).backgroundTask 'DiGi\.UI\.WPF\.Create\.VisualBackgroundTask\(DiGi\.Core\.Interfaces\.IBackgroundTask, string, string\)\.backgroundTask') is null\.

<a name='DiGi.UI.WPF.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.UI.WPF.Modify.CollapseAll(thisSystem.Windows.Controls.ItemCollection,bool)'></a>

## Modify\.CollapseAll\(this ItemCollection, bool\) Method

Collapses all items in the specified item collection\.

```csharp
public static void CollapseAll(this System.Windows.Controls.ItemCollection itemCollection, bool inverse=false);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.CollapseAll(thisSystem.Windows.Controls.ItemCollection,bool).itemCollection'></a>

`itemCollection` [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection')

The [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection') to collapse\.

<a name='DiGi.UI.WPF.Modify.CollapseAll(thisSystem.Windows.Controls.ItemCollection,bool).inverse'></a>

`inverse` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to invert the operation \(expand instead of collapse\)\.

<a name='DiGi.UI.WPF.Modify.ExpandAll(thisSystem.Windows.Controls.ItemCollection,bool)'></a>

## Modify\.ExpandAll\(this ItemCollection, bool\) Method

Recursively expands or collapses all items within the specified [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection')\.

```csharp
public static void ExpandAll(this System.Windows.Controls.ItemCollection itemCollection, bool inverse=false);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.ExpandAll(thisSystem.Windows.Controls.ItemCollection,bool).itemCollection'></a>

`itemCollection` [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection')

The collection of items to be expanded or collapsed\.

<a name='DiGi.UI.WPF.Modify.ExpandAll(thisSystem.Windows.Controls.ItemCollection,bool).inverse'></a>

`inverse` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, all items will be collapsed instead of expanded\. Defaults to `false`\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_)'></a>

## Modify\.Update\(this ItemCollection, ItemPath, Func\<ItemPath,ItemPathTreeViewItem\>\) Method

Updates or creates a tree view item based on the provided path within an item collection\.

```csharp
public static DiGi.UI.WPF.Classes.ItemPathTreeViewItem? Update(this System.Windows.Controls.ItemCollection? itemCollection, DiGi.UI.WPF.Classes.ItemPath? path, System.Func<DiGi.UI.WPF.Classes.ItemPath?,DiGi.UI.WPF.Classes.ItemPathTreeViewItem?>? createFunc);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_).itemCollection'></a>

`itemCollection` [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection')

The collection of items to search or update\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_).path'></a>

`path` [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

The target path for the tree view item\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_).createFunc'></a>

`createFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function used to create a new tree view item if it does not exist at the specified path\.

#### Returns
[ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem')  
The updated or created [ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem'), or `null` if the operation failed or inputs were null\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_,DiGi.UI.WPF.Classes.ItemPath)'></a>

## Modify\.Update\(this ItemCollection, ItemPath, Func\<ItemPath,ItemPathTreeViewItem\>, ItemPath\) Method

Updates or creates a tree view item based on the provided path within an item collection, optionally specifying a parent path for recursive traversal\.

```csharp
public static DiGi.UI.WPF.Classes.ItemPathTreeViewItem? Update(this System.Windows.Controls.ItemCollection? itemCollection, DiGi.UI.WPF.Classes.ItemPath? path, System.Func<DiGi.UI.WPF.Classes.ItemPath?,DiGi.UI.WPF.Classes.ItemPathTreeViewItem?>? createFunc, DiGi.UI.WPF.Classes.ItemPath? parentPath);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_,DiGi.UI.WPF.Classes.ItemPath).itemCollection'></a>

`itemCollection` [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection')

The collection of items to search or update\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_,DiGi.UI.WPF.Classes.ItemPath).path'></a>

`path` [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

The target path for the tree view item\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_,DiGi.UI.WPF.Classes.ItemPath).createFunc'></a>

`createFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function used to create a new tree view item if it does not exist at the specified path\.

<a name='DiGi.UI.WPF.Modify.Update(thisSystem.Windows.Controls.ItemCollection,DiGi.UI.WPF.Classes.ItemPath,System.Func_DiGi.UI.WPF.Classes.ItemPath,DiGi.UI.WPF.Classes.ItemPathTreeViewItem_,DiGi.UI.WPF.Classes.ItemPath).parentPath'></a>

`parentPath` [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

The path of the parent item, used during recursive updates to track depth and hierarchy\.

#### Returns
[ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem')  
The updated or created [ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem'), or `null` if the operation failed or inputs were null\.

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage)'></a>

## Modify\.Write\(BitmapImage\) Method

Writes the specified bitmap image to a file using a save file dialog\.

```csharp
public static bool Write(System.Windows.Media.Imaging.BitmapImage? bitmapImage);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage).bitmapImage'></a>

`bitmapImage` [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')

The bitmap image to save\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage,string)'></a>

## Modify\.Write\(BitmapImage, string\) Method

Writes the specified bitmap image to a file at the given path\.

```csharp
public static bool Write(System.Windows.Media.Imaging.BitmapImage? bitmapImage, string? path);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage,string).bitmapImage'></a>

`bitmapImage` [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')

The bitmap image to save\.

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The destination file path\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage,string)'></a>

## Modify\.Write\(BitmapImage, string\) Method

Writes the specified bitmap image to a file using a save file dialog to determine the destination path\.

```csharp
public static bool Write(System.Windows.Media.Imaging.BitmapImage? bitmapImage, out string? path);
```
#### Parameters

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage,string).bitmapImage'></a>

`bitmapImage` [System\.Windows\.Media\.Imaging\.BitmapImage](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage 'System\.Windows\.Media\.Imaging\.BitmapImage')

The bitmap image to save\.

<a name='DiGi.UI.WPF.Modify.Write(System.Windows.Media.Imaging.BitmapImage,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the path of the file that was saved, or null if the operation failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.UI.WPF.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.UI.WPF.Query.BitmapEncoder(thisDiGi.Core.IO.Classes.FileFilter)'></a>

## Query\.BitmapEncoder\(this FileFilter\) Method

Determines the appropriate [BitmapEncoder\(this FileFilter\)](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.BitmapEncoder(thisDiGi.Core.IO.Classes.FileFilter) 'DiGi\.UI\.WPF\.Query\.BitmapEncoder\(this DiGi\.Core\.IO\.Classes\.FileFilter\)') based on the file extensions provided in the specified file filter\.

```csharp
public static System.Windows.Media.Imaging.BitmapEncoder? BitmapEncoder(this DiGi.Core.IO.Classes.FileFilter? fileFilter);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.BitmapEncoder(thisDiGi.Core.IO.Classes.FileFilter).fileFilter'></a>

`fileFilter` [DiGi\.Core\.IO\.Classes\.FileFilter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.filefilter 'DiGi\.Core\.IO\.Classes\.FileFilter')

The file filter containing the list of extensions to evaluate\.

#### Returns
[System\.Windows\.Media\.Imaging\.BitmapEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapencoder 'System\.Windows\.Media\.Imaging\.BitmapEncoder')  
A [BitmapEncoder\(this FileFilter\)](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.BitmapEncoder(thisDiGi.Core.IO.Classes.FileFilter) 'DiGi\.UI\.WPF\.Query\.BitmapEncoder\(this DiGi\.Core\.IO\.Classes\.FileFilter\)') instance \(such as [System\.Windows\.Media\.Imaging\.JpegBitmapEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.jpegbitmapencoder 'System\.Windows\.Media\.Imaging\.JpegBitmapEncoder') or [System\.Windows\.Media\.Imaging\.PngBitmapEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.pngbitmapencoder 'System\.Windows\.Media\.Imaging\.PngBitmapEncoder')\) if a matching image extension is found; otherwise, null\.

<a name='DiGi.UI.WPF.Query.FileFilter(string)'></a>

## Query\.FileFilter\(string\) Method

Determines the appropriate file filter based on the provided file path's extension\.

```csharp
public static DiGi.Core.IO.Classes.FileFilter? FileFilter(string? path);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.FileFilter(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the file to evaluate\.

#### Returns
[DiGi\.Core\.IO\.Classes\.FileFilter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.filefilter 'DiGi\.Core\.IO\.Classes\.FileFilter')  
A [FileFilter\(string\)](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.FileFilter(string) 'DiGi\.UI\.WPF\.Query\.FileFilter\(string\)') instance if a matching filter is found; otherwise, null\.

<a name='DiGi.UI.WPF.Query.Parent_T_(System.Windows.DependencyObject)'></a>

## Query\.Parent\<T\>\(DependencyObject\) Method

Retrieves the parent [System\.Windows\.Controls\.ItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol 'System\.Windows\.Controls\.ItemsControl') of a given [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')\.

```csharp
public static T? Parent<T>(System.Windows.DependencyObject? dependencyObject)
    where T : System.Windows.Controls.ItemsControl;
```
#### Type parameters

<a name='DiGi.UI.WPF.Query.Parent_T_(System.Windows.DependencyObject).T'></a>

`T`

The type of the [System\.Windows\.Controls\.ItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol 'System\.Windows\.Controls\.ItemsControl') to return\.
#### Parameters

<a name='DiGi.UI.WPF.Query.Parent_T_(System.Windows.DependencyObject).dependencyObject'></a>

`dependencyObject` [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject')

The dependency object for which to find the parent container\.

#### Returns
[T](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.Parent_T_(System.Windows.DependencyObject).T 'DiGi\.UI\.WPF\.Query\.Parent\<T\>\(System\.Windows\.DependencyObject\)\.T')  
The parent [System\.Windows\.Controls\.ItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol 'System\.Windows\.Controls\.ItemsControl') cast to [T](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.Parent_T_(System.Windows.DependencyObject).T 'DiGi\.UI\.WPF\.Query\.Parent\<T\>\(System\.Windows\.DependencyObject\)\.T'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no such parent exists or the input is null\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,DiGi.Core.IO.Classes.FileFilter,bool)'></a>

## Query\.Path\(this Window, FileFilter, bool\) Method

Opens an open file dialog to select a file using a provided file filter and optionally including all files\.

```csharp
public static string? Path(this System.Windows.Window? window, DiGi.Core.IO.Classes.FileFilter? fileFilter=null, bool allFiles=false);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,DiGi.Core.IO.Classes.FileFilter,bool).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The owner window for the dialog\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,DiGi.Core.IO.Classes.FileFilter,bool).fileFilter'></a>

`fileFilter` [DiGi\.Core\.IO\.Classes\.FileFilter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.filefilter 'DiGi\.Core\.IO\.Classes\.FileFilter')

An optional [DiGi\.Core\.IO\.Classes\.FileFilter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.filefilter 'DiGi\.Core\.IO\.Classes\.FileFilter') used to filter the files\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,DiGi.Core.IO.Classes.FileFilter,bool).allFiles'></a>

`allFiles` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean indicating whether to include a filter for all files \(\*\.\*\)\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full path of the selected file, or null if the dialog was cancelled or closed\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,string)'></a>

## Query\.Path\(this Window, string, string\) Method

Opens an open file dialog to select a file based on a specific type name and extension\.

```csharp
public static string? Path(this System.Windows.Window? window, string fileTypeName, string fileExtension);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,string).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The owner window for the dialog\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,string).fileTypeName'></a>

`fileTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the file type\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,string).fileExtension'></a>

`fileExtension` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file extension to filter by\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full path of the selected file, or null if the dialog was cancelled or closed\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,System.Collections.Generic.IEnumerable_DiGi.Core.IO.Classes.FileFilter_)'></a>

## Query\.Path\(this Window, string, IEnumerable\<FileFilter\>\) Method

Opens an open file dialog to select a file using a custom title and a collection of file filters\.

```csharp
public static string? Path(this System.Windows.Window? window, string? title, System.Collections.Generic.IEnumerable<DiGi.Core.IO.Classes.FileFilter>? fileFilters);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,System.Collections.Generic.IEnumerable_DiGi.Core.IO.Classes.FileFilter_).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The owner window for the dialog\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,System.Collections.Generic.IEnumerable_DiGi.Core.IO.Classes.FileFilter_).title'></a>

`title` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional custom title for the dialog window\.

<a name='DiGi.UI.WPF.Query.Path(thisSystem.Windows.Window,string,System.Collections.Generic.IEnumerable_DiGi.Core.IO.Classes.FileFilter_).fileFilters'></a>

`fileFilters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.IO\.Classes\.FileFilter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.filefilter 'DiGi\.Core\.IO\.Classes\.FileFilter')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Core\.IO\.Classes\.FileFilter](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.filefilter 'DiGi\.Core\.IO\.Classes\.FileFilter') objects to define the file selection filters\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full path of the selected file, or null if the dialog was cancelled or closed\.

<a name='DiGi.UI.WPF.Query.Paths(thisSystem.Windows.Window,string,string)'></a>

## Query\.Paths\(this Window, string, string\) Method

Opens an open file dialog to select one or more files based on the specified type name and extension\.

```csharp
public static string[]? Paths(this System.Windows.Window window, string fileTypeName, string fileExtension);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.Paths(thisSystem.Windows.Window,string,string).window'></a>

`window` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The owner window that will display the dialog\.

<a name='DiGi.UI.WPF.Query.Paths(thisSystem.Windows.Window,string,string).fileTypeName'></a>

`fileTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the file type to be displayed in the dialog title and filter\.

<a name='DiGi.UI.WPF.Query.Paths(thisSystem.Windows.Window,string,string).fileExtension'></a>

`fileExtension` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file extension used for filtering files \(e\.g\., "txt"\)\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of strings containing the paths of the selected files, or `null` if the dialog was cancelled or closed\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,DiGi.UI.WPF.Controls.ProgressBarControl,string)'></a>

## Query\.ShowProgress\(this Action, ProgressBarControl, string\) Method

Executes the specified action while displaying indeterminate progress on the provided progress bar control\.

```csharp
public static void ShowProgress(this System.Action? action, DiGi.UI.WPF.Controls.ProgressBarControl? progressBarControl, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,DiGi.UI.WPF.Controls.ProgressBarControl,string).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to be executed\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,DiGi.UI.WPF.Controls.ProgressBarControl,string).progressBarControl'></a>

`progressBarControl` [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

The progress bar control used to display progress\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,DiGi.UI.WPF.Controls.ProgressBarControl,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display associated with the progress operation\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,System.Windows.Window,string)'></a>

## Query\.ShowProgress\(this Action, Window, string\) Method

Executes the specified action while displaying an indeterminate progress window\.

```csharp
public static void ShowProgress(this System.Action action, System.Windows.Window? owner=null, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,System.Windows.Window,string).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to be executed\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,System.Windows.Window,string).owner'></a>

`owner` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The optional owner window for the progress window\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action,System.Windows.Window,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display in the progress window\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string)'></a>

## Query\.ShowProgress\(this Action\<IDeterminateWorker\>, ProgressBarControl, string\) Method

Executes the specified action that requires a worker with determinate progress using the provided progress bar control\.

```csharp
public static void ShowProgress(this System.Action<DiGi.Core.Interfaces.IDeterminateWorker>? action, DiGi.UI.WPF.Controls.ProgressBarControl? progressBarControl, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[DiGi\.Core\.Interfaces\.IDeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker 'DiGi\.Core\.Interfaces\.IDeterminateWorker')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to be executed, receiving the determinate worker instance\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string).progressBarControl'></a>

`progressBarControl` [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

The progress bar control used to display progress\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display associated with the progress operation\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,string)'></a>

## Query\.ShowProgress\(this Action\<IDeterminateWorker\>, string\) Method

Executes the specified action that requires a worker with determinate progress while displaying a progress window\.

```csharp
public static void ShowProgress(this System.Action<DiGi.Core.Interfaces.IDeterminateWorker>? action, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,string).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[DiGi\.Core\.Interfaces\.IDeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker 'DiGi\.Core\.Interfaces\.IDeterminateWorker')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to be executed, receiving the determinate worker instance\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IDeterminateWorker_,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display in the progress window\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string)'></a>

## Query\.ShowProgress\(this Action\<IIndeterminateWorker\>, ProgressBarControl, string\) Method

Executes the specified action that requires a worker with indeterminate progress using the provided progress bar control\.

```csharp
public static void ShowProgress(this System.Action<DiGi.Core.Interfaces.IIndeterminateWorker>? action, DiGi.UI.WPF.Controls.ProgressBarControl? progressBarControl, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[DiGi\.Core\.Interfaces\.IIndeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker 'DiGi\.Core\.Interfaces\.IIndeterminateWorker')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to be executed, receiving the indeterminate worker instance\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string).progressBarControl'></a>

`progressBarControl` [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

The progress bar control used to display progress\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,DiGi.UI.WPF.Controls.ProgressBarControl,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display associated with the progress operation\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,System.Windows.Window,string)'></a>

## Query\.ShowProgress\(this Action\<IIndeterminateWorker\>, Window, string\) Method

Executes the specified action that requires a worker with indeterminate progress while displaying a progress window\.

```csharp
public static void ShowProgress(this System.Action<DiGi.Core.Interfaces.IIndeterminateWorker>? action, System.Windows.Window? owner=null, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,System.Windows.Window,string).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[DiGi\.Core\.Interfaces\.IIndeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker 'DiGi\.Core\.Interfaces\.IIndeterminateWorker')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to be executed, receiving the indeterminate worker instance\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,System.Windows.Window,string).owner'></a>

`owner` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The optional owner window for the progress window\.

<a name='DiGi.UI.WPF.Query.ShowProgress(thisSystem.Action_DiGi.Core.Interfaces.IIndeterminateWorker_,System.Windows.Window,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display in the progress window\.

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_)'></a>

## Query\.TagItems\<TItem,UControl\>\(this ItemCollection, bool, bool, Func\<UControl,bool\>\) Method

Extracts items stored in the Tag property of controls within an ItemCollection, optionally including nested collections and filtering by selection criteria\.

```csharp
public static System.Collections.Generic.List<TItem>? TagItems<TItem,UControl>(this System.Windows.Controls.ItemCollection itemCollection, bool includeNested=true, bool selected=false, System.Func<UControl,bool>? selectedFunc=null)
    where UControl : System.Windows.Controls.Control;
```
#### Type parameters

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).TItem'></a>

`TItem`

The type of the item to be retrieved from the Tag property\.

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).UControl'></a>

`UControl`

The specific control type to look for within the collection\.
#### Parameters

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).itemCollection'></a>

`itemCollection` [System\.Windows\.Controls\.ItemCollection](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection 'System\.Windows\.Controls\.ItemCollection')

The ItemCollection to process\.

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, recursively processes nested ItemsControls\. Defaults to `true`\.

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, only items from controls that satisfy the [selectedFunc](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).selectedFunc 'DiGi\.UI\.WPF\.Query\.TagItems\<TItem,UControl\>\(this System\.Windows\.Controls\.ItemCollection, bool, bool, System\.Func\<UControl,bool\>\)\.selectedFunc') are included\. Defaults to `false`\.

<a name='DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).selectedFunc'></a>

`selectedFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UControl](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).UControl 'DiGi\.UI\.WPF\.Query\.TagItems\<TItem,UControl\>\(this System\.Windows\.Controls\.ItemCollection, bool, bool, System\.Func\<UControl,bool\>\)\.UControl')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function used to evaluate if a control is selected\. This must be provided if [selected](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).selected 'DiGi\.UI\.WPF\.Query\.TagItems\<TItem,UControl\>\(this System\.Windows\.Controls\.ItemCollection, bool, bool, System\.Func\<UControl,bool\>\)\.selected') is set to `true`\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TItem](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).TItem 'DiGi\.UI\.WPF\.Query\.TagItems\<TItem,UControl\>\(this System\.Windows\.Controls\.ItemCollection, bool, bool, System\.Func\<UControl,bool\>\)\.TItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of items found in the tags, or `null` if the provided [itemCollection](DiGi.UI.WPF.md#DiGi.UI.WPF.Query.TagItems_TItem,UControl_(thisSystem.Windows.Controls.ItemCollection,bool,bool,System.Func_UControl,bool_).itemCollection 'DiGi\.UI\.WPF\.Query\.TagItems\<TItem,UControl\>\(this System\.Windows\.Controls\.ItemCollection, bool, bool, System\.Func\<UControl,bool\>\)\.itemCollection') is null\.