using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clock.Models;

namespace Clock.Views
{
    public interface IView
    {
        void Display(TimeModel model_p);
    }
}
