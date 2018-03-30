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

using Clock.Models;

namespace Clock.Views
{
    /// <summary>
    /// Interaction logic for DigitialClockView.xaml
    /// </summary>
    public partial class AnalogClockView : UserControl, IView
    {
        public AnalogClockView()
        {
            InitializeComponent();
        }

        public void Display(TimeModel time_modle_p)
        {
            TimeDisplay_txtb.Text = time_modle_p.Hours.ToString("D2") + ":" + time_modle_p.Minutes.ToString("D2") + ":" + time_modle_p.Seconds.ToString("D2") + time_modle_p.AmOrPm;
        }
    }
}
