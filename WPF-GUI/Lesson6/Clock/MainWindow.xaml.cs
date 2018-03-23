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

using System.Timers;
using Clock.Controllers;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClockController TimeControler_m;

        public MainWindow()
        {
            InitializeComponent();

            TimeControler_m = new ClockController(DigitialClock_uc);

            Timer clock_timer = new Timer(1000);
            clock_timer.Elapsed += UpdateTime;
        }

        public void UpdateTime(object sender, ElapsedEventArgs e)
        {
            TimeControler_m.UpdateTime();
        }
    }
}
