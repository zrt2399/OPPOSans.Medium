using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using Avalonia.Media.Fonts;

namespace OPPOSans.Medium.Avalonia
{
    /// <summary>
    /// Provides extension methods related to the OPPOSans Medium font.
    /// </summary>
    public static class OPPOSansExtension
    {
        /// <summary>
        /// Gets the resource key used to register the OPPOSans Medium font in application resources.
        /// </summary>
        public const string MediumFontResourceKey = "OPPOSansMediumFontFamily";
        /// <summary>
        /// Gets the FontFamily for OPPOSans Medium.
        /// </summary>
        public static FontFamily MediumFont { get; }

        static OPPOSansExtension()
        {
            var assemblyName = typeof(OPPOSansExtension).Assembly.GetName().Name;
            // Directly reference the embedded font using the avares URI scheme
            MediumFont = new FontFamily($"avares://{assemblyName}/Assets/Fonts#OPPOSans M");
        }

        /// <summary>
        /// Registers the OPPOSans Medium font to the application's global resources.
        /// This allows it to be referenced in XAML using the <see cref="MediumFontResourceKey"/> key.
        /// </summary>
        public static void RegisterToApplicationResources()
        {
            if (Application.Current is { } application)
            {
                application.Resources.TryAdd(MediumFontResourceKey, MediumFont);
            }
        }

        /// <summary>
        /// Configures Avalonia to use the embedded OPPOSans Medium font as the default font family.
        /// </summary>
        public static AppBuilder WithOPPOSansMediumFont(this AppBuilder appBuilder)
        {
            return appBuilder.ConfigureFonts(fontManager =>
            {
                // 1. 定义一个“虚拟”的自定义 URI，这是你在代码/XAML中引用它的别名
                var customFontKey = new Uri("fonts:oppo", UriKind.Absolute);

                var assemblyName = typeof(OPPOSansExtension).Assembly.GetName().Name;
                var realResourceSource = new Uri($"avares://{assemblyName}/Assets/Fonts", UriKind.Absolute);

                // 2. 实例化 Avalonia 提供的嵌入字体集合对象
                var embeddedCollection = new EmbeddedFontCollection(customFontKey, realResourceSource);

                // 将集合注册到系统中
                fontManager.AddFontCollection(embeddedCollection);
            }).With(new FontManagerOptions
            {
                // 3. 将默认字体指向你刚刚注册的虚拟 URI
                // 格式：虚拟前缀#字体族名称 (F12里的Family Name)
                DefaultFamilyName = "fonts:oppo#OPPOSans M"
            });
        }
    }
}