using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;

namespace OPPOSans.Medium.Wpf
{
    /// <summary>
    /// Provides methods and properties related to the OPPOSans Medium font.
    /// </summary>
    public class OPPOSansExtension
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
            try
            {
                var assemblyName = typeof(OPPOSansExtension).Assembly.GetName().Name;

                // 注意基础 Uri 必须以斜杠结尾，指向包含字体的文件夹
                Uri baseUri = new Uri($"pack://application:,,,/{assemblyName};component/Assets/Fonts/");

                // 相对路径必须用 "./" 开头，不要带文件名，直接搜文件夹里的元数据即可
                MediumFont = new FontFamily(baseUri, "./#OPPOSans M");
            }
            finally
            {
                MediumFont ??= SystemFonts.MessageFontFamily;
            }
        }

        /// <summary>
        /// Registers the OPPOSans Medium font to the application's global resources.
        /// This allows it to be referenced in XAML using the <see cref="MediumFontResourceKey"/> key.
        /// </summary>
        public static void RegisterToApplicationResources()
        {
            if (Application.Current is { } application)
            {
                if (!application.Resources.Contains(MediumFontResourceKey))
                {
                    application.Resources.Add(MediumFontResourceKey, MediumFont);
                }
            }
        }

        /// <summary>
        /// Applies the OPPOSans Medium font globally to common UI controls by overriding dependency property metadata.
        /// </summary>
        public static void ApplyGlobalMediumFont()
        {
            Control.FontFamilyProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata(MediumFont));
            Control.FontFamilyProperty.OverrideMetadata(typeof(ToolTip), new FrameworkPropertyMetadata(MediumFont));
            Control.FontFamilyProperty.OverrideMetadata(typeof(ContextMenu), new FrameworkPropertyMetadata(MediumFont));

            Control.FontFamilyProperty.OverrideMetadata(typeof(TextBoxBase), new FrameworkPropertyMetadata(MediumFont));
            Control.FontFamilyProperty.OverrideMetadata(typeof(ContentControl), new FrameworkPropertyMetadata(MediumFont));
            TextBlock.FontFamilyProperty.OverrideMetadata(typeof(TextBlock), new FrameworkPropertyMetadata(MediumFont));
            TextElement.FontFamilyProperty.OverrideMetadata(typeof(TextElement), new FrameworkPropertyMetadata(MediumFont));
        }
    }
}