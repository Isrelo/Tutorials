using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;

namespace TransactionRegister.States
{
    public class SelectTransactionState : State
    {
        public override void UnselectTransaction(ApplicationContext app_context_p)
        {
            base.UnselectTransaction(app_context_p);
        }

        public override void DeleteTransaction(ApplicationContext app_context_p)
        {
            base.DeleteTransaction(app_context_p);
        }
    }
}
