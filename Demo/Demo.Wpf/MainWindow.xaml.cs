using System.Collections.Generic;
using System.Windows;

namespace Demo.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FontSizeComboBox.ItemsSource = new List<double> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            FontSizeComboBox.SelectedItem = 14d;

            FontStyleComboBox.ItemsSource = new List<string> { "Normal", "Italic", "Oblique" };
            FontStyleComboBox.SelectedItem = "Normal";

            FontWeightComboBox.ItemsSource = new List<string>
            {
                "Thin",
                "Light",
                "Regular",
                "Medium",
                "SemiBold",
                "Bold",
                "ExtraBold",
                "Black"
            };
            FontWeightComboBox.SelectedItem = "Regular";
        }
    }
}