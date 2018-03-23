using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clock.Models;
using Clock.Views;

namespace Clock.Controllers
{
    class ClockController
    {
        ClockView DigitalClock_m;
        TimeModel TimeData_m;

        public ClockController()
        {
            TimeData_m = new TimeModel();
            TimeData_m.Hours = 8;
            TimeData_m.Minutes = 36;
            TimeData_m.Seconds = 40;
            TimeData_m.AmOrPm = "PM";

            DigitalClock_m = new ClockView();
            DigitalClock_m.Display(TimeData_m.Hours, TimeData_m.Minutes, TimeData_m.Seconds, TimeData_m.AmOrPm);
        }
    }
}
