# HotKey

[![NuGet](https://img.shields.io/nuget/v/Asjc.HotKey)](https://www.nuget.org/packages/Asjc.Collections.HotKey/)
[![NuGet](https://img.shields.io/nuget/v/Asjc.HotKey.Wpf)](https://www.nuget.org/packages/Asjc.Collections.HotKey.Wpf/)
[![NuGet](https://img.shields.io/nuget/v/Asjc.HotKey.WinForms)](https://www.nuget.org/packages/Asjc.Collections.HotKey.WinForms/)

Register hotkeys easily!

## Getting Started

First, install `AS.HotKey.Wpf` or `AS.HotKey.WinForms`, and then import the corresponding namespace.

Quickly register hotkeys with just **one line** of code, such as:

```csharp
new HotKey(Key.Space, Modifiers.Ctrl, _ => MessageBox.Show("Ctrl + Space"));
```

