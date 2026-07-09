#### [DiGi\.UI\.WPF](DiGi.UI.WPF.Overview.md 'DiGi\.UI\.WPF\.Overview')

## DiGi\.UI\.WPF\.Windows Namespace
### Classes

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow'></a>

## CancellableProgressBarWindow Class

Interaction logic for CancellableProgressBarWindow\.xaml

```csharp
public class CancellableProgressBarWindow : System.Windows.Window, DiGi.UI.WPF.Interfaces.IWindow, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') → CancellableProgressBarWindow

Implements [IWindow](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWindow 'DiGi\.UI\.WPF\.Interfaces\.IWindow'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.CancellableProgressBarWindow()'></a>

## CancellableProgressBarWindow\(\) Constructor

Initializes a new instance of the [CancellableProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CancellableProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.CancellableProgressBarWindow') class\.

```csharp
public CancellableProgressBarWindow();
```
### Properties

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.CancellationPending'></a>

## CancellableProgressBarWindow\.CancellationPending Property

Gets a value indicating whether a cancellation is pending\.

```csharp
public bool CancellationPending { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.IsIndeterminate'></a>

## CancellableProgressBarWindow\.IsIndeterminate Property

Gets or sets a value indicating whether the progress bar is in an indeterminate state\.

```csharp
public bool IsIndeterminate { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.Maximum'></a>

## CancellableProgressBarWindow\.Maximum Property

Gets or sets the maximum value for progress reporting\.

```csharp
public double Maximum { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.InitializeComponent()'></a>

## CancellableProgressBarWindow\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.Update(double,string)'></a>

## CancellableProgressBarWindow\.Update\(double, string\) Method

Updates the progress bar value and the associated status text\.

```csharp
public void Update(double value, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.Update(double,string).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The current progress value\.

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.Update(double,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional status text to display\.
### Events

<a name='DiGi.UI.WPF.Windows.CancellableProgressBarWindow.Cancelling'></a>

## CancellableProgressBarWindow\.Cancelling Event

Occurs when the user requests to cancel the current operation\.

```csharp
public event CancellingEventHandler? Cancelling;
```

#### Event Type
[CancellingEventHandler\(object, CancellingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.CancellingEventHandler(object,DiGi.UI.WPF.Classes.CancellingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.CancellingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.CancellingEventArgs\)')

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow'></a>

## CheckBoxTreeViewWindow Class

Interaction logic for CheckBoxTreeViewWindow\.xaml

```csharp
public class CheckBoxTreeViewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') → CheckBoxTreeViewWindow

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.CheckBoxTreeViewWindow()'></a>

## CheckBoxTreeViewWindow\(\) Constructor

Initializes a new instance of the [CheckBoxTreeViewWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow 'DiGi\.UI\.WPF\.Windows\.CheckBoxTreeViewWindow') class\.

```csharp
public CheckBoxTreeViewWindow();
```

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.CheckBoxTreeViewWindow(string)'></a>

## CheckBoxTreeViewWindow\(string\) Constructor

Initializes a new instance of the [CheckBoxTreeViewWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow 'DiGi\.UI\.WPF\.Windows\.CheckBoxTreeViewWindow') class with a specified title\.

```csharp
public CheckBoxTreeViewWindow(string? title);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.CheckBoxTreeViewWindow(string).title'></a>

`title` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The title to be displayed on the window\.
### Methods

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.CollapseAll()'></a>

## CheckBoxTreeViewWindow\.CollapseAll\(\) Method

Collapses all nodes within the tree view control\.

```csharp
public void CollapseAll();
```

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.ExpandAll()'></a>

## CheckBoxTreeViewWindow\.ExpandAll\(\) Method

Expands all nodes within the tree view control\.

```csharp
public void ExpandAll();
```

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.GetItems_T_(bool)'></a>

## CheckBoxTreeViewWindow\.GetItems\<T\>\(bool\) Method

Retrieves a list of items from the tree view control\.

```csharp
public System.Collections.Generic.List<T>? GetItems<T>(bool selected=true);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.GetItems_T_(bool).T'></a>

`T`

The type of items to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.GetItems_T_(bool).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, only selected items are returned; otherwise, all items are returned\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.CheckBoxTreeViewWindow\.GetItems\<T\>\(bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of items of type [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.CheckBoxTreeViewWindow\.GetItems\<T\>\(bool\)\.T'), or `null` if no items are found\.

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.InitializeComponent()'></a>

## CheckBoxTreeViewWindow\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## CheckBoxTreeViewWindow\.SetItems\<T\>\(IEnumerable\<T\>\) Method

Sets the items to be displayed in the tree view control\.

```csharp
public void SetItems<T>(System.Collections.Generic.IEnumerable<T> values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of items to set\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Windows\.CheckBoxTreeViewWindow\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of items to populate the tree view\.
### Events

<a name='DiGi.UI.WPF.Windows.CheckBoxTreeViewWindow.ItemAdding'></a>

## CheckBoxTreeViewWindow\.ItemAdding Event

Occurs when an item is being added to the tree view control\.

```csharp
public event CheckBoxTreeViewItemAddingEventHandler? ItemAdding;
```

#### Event Type
[CheckBoxTreeViewItemAddingEventHandler\(object, CheckBoxTreeViewItemAddingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.CheckBoxTreeViewItemAddingEventHandler(object,DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.CheckBoxTreeViewItemAddingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.CheckBoxTreeViewItemAddingEventArgs\)')

<a name='DiGi.UI.WPF.Windows.ListBoxWindow'></a>

## ListBoxWindow Class

Interaction logic for ListBoxWindow\.xaml

```csharp
public class ListBoxWindow : System.Windows.Window, DiGi.UI.WPF.Interfaces.IWindow, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') → ListBoxWindow

Implements [IWindow](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWindow 'DiGi\.UI\.WPF\.Interfaces\.IWindow'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.ListBoxWindow()'></a>

## ListBoxWindow\(\) Constructor

Initializes a new instance of the [ListBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow') class\.

```csharp
public ListBoxWindow();
```

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.ListBoxWindow(string)'></a>

## ListBoxWindow\(string\) Constructor

Initializes a new instance of the [ListBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow') class with a specified title\.

```csharp
public ListBoxWindow(string title);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.ListBoxWindow(string).title'></a>

`title` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to be displayed as the window title\.
### Properties

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.SelectionMode'></a>

## ListBoxWindow\.SelectionMode Property

Gets or sets the selection mode of the internal list box control\.

```csharp
public System.Windows.Controls.SelectionMode SelectionMode { get; set; }
```

#### Property Value
[System\.Windows\.Controls\.SelectionMode](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.selectionmode 'System\.Windows\.Controls\.SelectionMode')
### Methods

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.GetItems_T_(bool)'></a>

## ListBoxWindow\.GetItems\<T\>\(bool\) Method

Retrieves a list of items from the internal list box control\.

```csharp
public System.Collections.Generic.List<T>? GetItems<T>(bool selected=true);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.GetItems_T_(bool).T'></a>

`T`

The type of the items to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.GetItems_T_(bool).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, only selected items are retrieved; otherwise, all items are retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow\.GetItems\<T\>\(bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the items of type [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow\.GetItems\<T\>\(bool\)\.T'), or `null` if no items are available\.

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.InitializeComponent()'></a>

## ListBoxWindow\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## ListBoxWindow\.SetItems\<T\>\(IEnumerable\<T\>\) Method

Sets the collection of items for the internal list box control\.

```csharp
public void SetItems<T>(System.Collections.Generic.IEnumerable<T> values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the items to be set\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of values to populate the list box\.
### Events

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.ItemAdding'></a>

## ListBoxWindow\.ItemAdding Event

Occurs when an item is being added to the internal list box control\.

```csharp
public event ListBoxItemAddingEventHandler? ItemAdding;
```

#### Event Type
[ListBoxItemAddingEventHandler\(object, ListBoxItemAddingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.ListBoxItemAddingEventHandler(object,DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.ListBoxItemAddingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.ListBoxItemAddingEventArgs\)')

<a name='DiGi.UI.WPF.Windows.ListBoxWindow.SelectionChanged'></a>

## ListBoxWindow\.SelectionChanged Event

Occurs when the selection within the internal list box control changes\.

```csharp
public event SelectionChangedEventHandler? SelectionChanged;
```

#### Event Type
[System\.Windows\.Controls\.SelectionChangedEventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.selectionchangedeventhandler 'System\.Windows\.Controls\.SelectionChangedEventHandler')

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow'></a>

## ProgressBarWindow Class

Interaction logic for ProgressBarWindow\.xaml

```csharp
public class ProgressBarWindow : System.Windows.Window, DiGi.UI.WPF.Interfaces.IWindow, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') → ProgressBarWindow

Implements [IWindow](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWindow 'DiGi\.UI\.WPF\.Interfaces\.IWindow'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.ProgressBarWindow()'></a>

## ProgressBarWindow\(\) Constructor

Initializes a new instance of the [ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow') class\.

```csharp
public ProgressBarWindow();
```
### Properties

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.IsIndeterminate'></a>

## ProgressBarWindow\.IsIndeterminate Property

Gets or sets a value indicating whether the progress bar is in an indeterminate state\.

```csharp
public bool IsIndeterminate { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.Maximum'></a>

## ProgressBarWindow\.Maximum Property

Gets or sets the maximum value for progress reporting\.

```csharp
public double Maximum { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.InitializeComponent()'></a>

## ProgressBarWindow\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.Update(double,string)'></a>

## ProgressBarWindow\.Update\(double, string\) Method

Updates the progress bar's current value and optionally updates the status text\.

```csharp
public void Update(double value, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.Update(double,string).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The current progress value to be displayed\.

<a name='DiGi.UI.WPF.Windows.ProgressBarWindow.Update(double,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional text to display as a status message\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow'></a>

## TextBoxWindow Class

Interaction logic for TextBoxWindow\.xaml

```csharp
public class TextBoxWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') → TextBoxWindow

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow()'></a>

## TextBoxWindow\(\) Constructor

Initializes a new instance of the [TextBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow') class\.

```csharp
public TextBoxWindow();
```

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string)'></a>

## TextBoxWindow\(string, string\) Constructor

Initializes a new instance of the [TextBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow') class with specified title and initial text\.

```csharp
public TextBoxWindow(string? title, string? text);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string).title'></a>

`title` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The window title\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The initial text for the text box\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string,object)'></a>

## TextBoxWindow\(string, string, object\) Constructor

Initializes a new instance of the [TextBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow') class with specified title, initial text, and an associated value\.

```csharp
public TextBoxWindow(string? title, string? text, object? value);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string,object).title'></a>

`title` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The window title\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string,object).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The initial text for the text box\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TextBoxWindow(string,string,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object value to be converted to a string representation\.
### Properties

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.Text'></a>

## TextBoxWindow\.Text Property

Gets or sets the text content of the main text box control\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.Validation'></a>

## TextBoxWindow\.Validation Property

Gets or sets the validation function used to verify the input text\.

```csharp
public System.Func<string,bool>? Validation { get; set; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.Value'></a>

## TextBoxWindow\.Value Property

Gets or sets the value associated with the text box control\.

```csharp
public string? Value { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_()'></a>

## TextBoxWindow\.GetValue\<T\>\(\) Method

Retrieves the current value from the text box as the specified type\.

```csharp
public T? GetValue<T>();
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_().T'></a>

`T`

The target type to retrieve\.

#### Returns
[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_().T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.GetValue\<T\>\(\)\.T')  
The retrieved value of type [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_().T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.GetValue\<T\>\(\)\.T'), or the default value if retrieval fails\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T)'></a>

## TextBoxWindow\.GetValue\<T\>\(T\) Method

Retrieves the current value from the text box as the specified type, returning a default value if retrieval fails\.

```csharp
public T? GetValue<T>(T? defaultValue);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T).T'></a>

`T`

The target type to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T).defaultValue'></a>

`defaultValue` [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T).T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.GetValue\<T\>\(T\)\.T')

The value to return if the actual value cannot be retrieved or converted\.

#### Returns
[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T).T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.GetValue\<T\>\(T\)\.T')  
The retrieved value of type [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T).T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.GetValue\<T\>\(T\)\.T'), or the provided [defaultValue](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.GetValue_T_(T).defaultValue 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.GetValue\<T\>\(T\)\.defaultValue')\.

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.InitializeComponent()'></a>

## TextBoxWindow\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TryGetValue_T_(T)'></a>

## TextBoxWindow\.TryGetValue\<T\>\(T\) Method

Attempts to retrieve the current value from the text box as the specified type\.

```csharp
public bool TryGetValue<T>(out T? value);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TryGetValue_T_(T).T'></a>

`T`

The target type to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.TextBoxWindow.TryGetValue_T_(T).value'></a>

`value` [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.TryGetValue_T_(T).T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.TryGetValue\<T\>\(T\)\.T')

When this method returns, contains the retrieved value if successful; otherwise, the default value of [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TextBoxWindow.TryGetValue_T_(T).T 'DiGi\.UI\.WPF\.Windows\.TextBoxWindow\.TryGetValue\<T\>\(T\)\.T')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved and converted; otherwise, false\.

<a name='DiGi.UI.WPF.Windows.TreeViewWindow'></a>

## TreeViewWindow Class

Interaction logic for TreeViewWindow\.xaml

```csharp
public class TreeViewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') → TreeViewWindow

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.TreeViewWindow()'></a>

## TreeViewWindow\(\) Constructor

Initializes a new instance of the [TreeViewWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TreeViewWindow 'DiGi\.UI\.WPF\.Windows\.TreeViewWindow') class\.

```csharp
public TreeViewWindow();
```

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.TreeViewWindow(string)'></a>

## TreeViewWindow\(string\) Constructor

Initializes a new instance of the [TreeViewWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TreeViewWindow 'DiGi\.UI\.WPF\.Windows\.TreeViewWindow') class with a specified title\.

```csharp
public TreeViewWindow(string? title);
```
#### Parameters

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.TreeViewWindow(string).title'></a>

`title` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The window title to be displayed\.
### Methods

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.CollapseAll()'></a>

## TreeViewWindow\.CollapseAll\(\) Method

Collapses all nodes in the main tree view control\.

```csharp
public void CollapseAll();
```

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.ExpandAll()'></a>

## TreeViewWindow\.ExpandAll\(\) Method

Expands all nodes in the main tree view control\.

```csharp
public void ExpandAll();
```

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.GetItems_T_(bool)'></a>

## TreeViewWindow\.GetItems\<T\>\(bool\) Method

Retrieves a list of items of type [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TreeViewWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.TreeViewWindow\.GetItems\<T\>\(bool\)\.T') from the tree view\.

```csharp
public System.Collections.Generic.List<T>? GetItems<T>(bool selected=true);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.GetItems_T_(bool).T'></a>

`T`

The type of items to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.GetItems_T_(bool).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, only selected items are returned; otherwise, all items are returned\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TreeViewWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.TreeViewWindow\.GetItems\<T\>\(bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the retrieved items of type [T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TreeViewWindow.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Windows\.TreeViewWindow\.GetItems\<T\>\(bool\)\.T'), or `null`\.

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.InitializeComponent()'></a>

## TreeViewWindow\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## TreeViewWindow\.SetItems\<T\>\(IEnumerable\<T\>\) Method

Sets the items of the tree view to the specified collection\.

```csharp
public void SetItems<T>(System.Collections.Generic.IEnumerable<T> values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of items to set\.
#### Parameters

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.TreeViewWindow.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Windows\.TreeViewWindow\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable collection of values to populate the tree view\.
### Events

<a name='DiGi.UI.WPF.Windows.TreeViewWindow.ItemAdding'></a>

## TreeViewWindow\.ItemAdding Event

Occurs when an item is being added to the tree view control\.

```csharp
public event TreeViewItemAddingEventHandler? ItemAdding;
```

#### Event Type
[TreeViewItemAddingEventHandler\(object, TreeViewItemAddingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.TreeViewItemAddingEventHandler(object,DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.TreeViewItemAddingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.TreeViewItemAddingEventArgs\)')