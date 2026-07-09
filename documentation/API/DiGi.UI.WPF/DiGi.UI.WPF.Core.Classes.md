#### [DiGi\.UI\.WPF](DiGi.UI.WPF.Overview.md 'DiGi\.UI\.WPF\.Overview')

## DiGi\.UI\.WPF\.Core\.Classes Namespace
### Classes

<a name='DiGi.UI.WPF.Core.Classes.Debouncer'></a>

## Debouncer Class

Provides functionality to debounce actions, ensuring that a specified action is executed only after a certain amount of time has passed since the last request\.

```csharp
public sealed class Debouncer
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Debouncer
### Constructors

<a name='DiGi.UI.WPF.Core.Classes.Debouncer.Debouncer(int)'></a>

## Debouncer\(int\) Constructor

Initializes a new instance of the [Debouncer](DiGi.UI.WPF.Core.Classes.md#DiGi.UI.WPF.Core.Classes.Debouncer 'DiGi\.UI\.WPF\.Core\.Classes\.Debouncer') class\.

```csharp
public Debouncer(int delay=1000);
```
#### Parameters

<a name='DiGi.UI.WPF.Core.Classes.Debouncer.Debouncer(int).delay'></a>

`delay` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The interval in milliseconds to wait before executing the debounced action\.
### Methods

<a name='DiGi.UI.WPF.Core.Classes.Debouncer.Run(System.Action)'></a>

## Debouncer\.Run\(Action\) Method

Schedules the specified action for execution after the debounce interval has elapsed\. 
If this method is called again before the timer expires, the previous request is canceled and the timer resets\.

```csharp
public void Run(System.Action action);
```
#### Parameters

<a name='DiGi.UI.WPF.Core.Classes.Debouncer.Run(System.Action).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to be executed once the debounce period completes\.