using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Views;
using TransactionRegister.Models;

namespace TransactionRegister.Controllers
{
    public class WorkspaceController
    {
        List<IView> views_to_update_m;

        public WorkspaceController()
        {
            views_to_update_m = new List<IView>();
        }

        public void AddView(IView view_to_add_p)
        {
            views_to_update_m.Add(view_to_add_p);
        }

        public void UpdateViews(BaseModel updated_model_p)
        {
            foreach (IView view_to_update in views_to_update_m)
            {
                view_to_update.Draw(updated_model_p);
            }
        }
    }
}
