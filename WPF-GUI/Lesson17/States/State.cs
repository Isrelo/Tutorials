using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;

namespace TransactionRegister.States
{
    public abstract class State
    {
        public virtual void Starting(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new StartingState();
        }

        public virtual void AddTransaction(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new AddTransactionState();
        }

        public virtual void EditTransaction(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new EditTransactionState();
        }

        public virtual void SaveTransaction(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new SaveTransactionState();
        }

        public virtual void Cancel(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new CancelTransactionState();
        }

        public virtual void SelectTransaction(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new SelectTransactionState();
        }

        public virtual void UnselectTransaction(ApplicationContext app_context_p)
        {
            app_context_p.CurrentState_m = new UnselectTransactionState();
        }

        public virtual void DeleteTransaction(ApplicationContext app_context_p)
        {
        }
    }
}
