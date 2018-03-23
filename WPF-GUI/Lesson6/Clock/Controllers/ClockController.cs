using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clock.Models;
using Clock.Views;

namespace Clock.Controllers
{
    public class ClockController
    {
        TimeModel TimeData_m;
        DigitialClockView DigitalClockView_m;

        public ClockController(DigitialClockView digital_clock_view_p)
        {
            DigitalClockView_m = digital_clock_view_p;
        }

        public void UpdateTime()
        {
            DateTime current_time = DateTime.Now;

            TimeData_m = new TimeModel();
            TimeData_m.Hours = current_time.Hour;
            TimeData_m.Minutes = current_time.Minute;
            TimeData_m.Seconds = current_time.Second;
            TimeData_m.AmOrPm = current_time.ToString("tt");

            DigitalClockView_m.Display(TimeData_m);
        }
    }
}
