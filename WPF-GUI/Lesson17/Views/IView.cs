using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Models;

namespace TransactionRegister.Views
{
    public interface IView
    {
        void Draw(BaseModel model_to_draw_p);
    }
}
