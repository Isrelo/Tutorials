using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using TransactionRegister.Models;

namespace TransactionRegister.ViewModels
{
    public class WorkspaceViewModel : BaseModel
    {
        public List<UIElement> Controls_m;

        public WorkspaceViewModel()
        {
            Controls_m = new List<UIElement>();
        }
    }
}
