using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFirstCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Clear the Calculator's Display.
        private void CelarDisplay_Click(object sender, RoutedEventArgs e)
        {
            displayLbl.Content = "0";
        }

        // This click event gets called for every standard button.
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button clicked_button = (Button)sender;

            // If the display contains a zero we want to clear the display.
            if (displayLbl.Content.ToString() == "0")
            {
                displayLbl.Content = "";
            }

            // Take what's in the display and append it to the end of the display.
            displayLbl.Content = displayLbl.Content.ToString() + clicked_button.Content.ToString();
        }

        // Declare that FirstNumber_m exists.
        decimal FirstNumber_m = 0;
        private void PlussButton_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(displayLbl.Content.ToString(), out FirstNumber_m);
        }
    }
}
