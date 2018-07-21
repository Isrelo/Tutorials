using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;

namespace TransactionRegister.States
{
    public class EditTransactionState : State
    {
        public override void Starting(ApplicationContext app_context_p)
        {
            base.Starting(app_context_p);
        }

        public override void SaveTransaction(ApplicationContext app_context_p)
        {
            base.SaveTransaction(app_context_p);
        }

        public override void Cancel(ApplicationContext app_context_p)
        {
            base.Cancel(app_context_p);
        }
    }
}
