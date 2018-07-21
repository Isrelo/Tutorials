using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;

namespace TransactionRegister.States
{
    public class StartingState : State
    {
        public override void AddTransaction(ApplicationContext app_context_p)
        {
            base.AddTransaction(app_context_p);
        }

        public override void EditTransaction(ApplicationContext app_context_p)
        {
            base.EditTransaction(app_context_p);
        }

        public override void SelectTransaction(ApplicationContext app_context_p)
        {
            base.SelectTransaction(app_context_p);
        }
    }
}
