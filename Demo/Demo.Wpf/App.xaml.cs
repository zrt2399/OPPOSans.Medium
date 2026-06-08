using System.Windows;
using OPPOSans.Medium.Wpf;

namespace Demo.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            OPPOSansExtension.ApplyGlobalOPPOSansMediumFont();
            base.OnStartup(e);
        }
    }
}