![License](https://img.shields.io/badge/license-MIT-8CBA04) 
[![NuGet - Avalonia](https://img.shields.io/nuget/v/OPPOSans.Medium.Avalonia?label=OPPOSans.Medium.Avalonia)](https://www.nuget.org/packages/OPPOSans.Medium.Avalonia)
[![NuGet - WPF](https://img.shields.io/nuget/v/OPPOSans.Medium.Wpf?label=OPPOSans.Medium.Wpf)](https://www.nuget.org/packages/OPPOSans.Medium.Wpf)

# OPPOSans Font for .NET (Avalonia & WPF)
The OPPOSans Font released in 2019, packaged for easy use in Avalonia and WPF applications.

## 🚀 Avalonia Usage

### 💡 Install
Add nuget package:
```bash
dotnet add package OPPOSans.Medium.Avalonia
```

### 🛠️ Quick Start
Update your `Program.cs`:
```csharp
public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
#if DEBUG
                .WithDeveloperTools()
#endif
                //.WithInterFont()
                .WithOPPOSansMediumFont() // Add this line
                .LogToTrace();
```

Or use the `FontFamily` directly in XAML or C#:
```xml
<TextBlock FontFamily="{x:Static OPPOSansExtension.MediumFont}">TextBlock</TextBlock>
```

```csharp
var myFont = OPPOSansExtension.MediumFont;
```

---

## 🚀 WPF Usage

### 💡 Install
Add nuget package:
```bash
dotnet add package OPPOSans.Medium.Wpf
```

### 🛠️ Quick Start
Update your `App.xaml.cs`:
```csharp
protected override void OnStartup(StartupEventArgs e)
{
    // Apply the font globally to common UI controls
    OPPOSansExtension.ApplyGlobalOPPOSansMediumFont();
    base.OnStartup(e);
}
```

Or use the `FontFamily` directly in XAML or C#:
```xml
<TextBlock FontFamily="{x:Static OPPOSansExtension.MediumFont}">TextBlock</TextBlock>
```

```csharp
var myFont = OPPOSansExtension.MediumFont;
```
