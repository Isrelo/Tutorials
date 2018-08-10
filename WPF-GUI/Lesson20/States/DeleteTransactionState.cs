using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;
using TransactionRegister.Controllers;

namespace TransactionRegister.States
{
    public class DeleteTransactionState : IState
    {
        public ToolbarController ToolbarController_m { get; set; }
        public WorkspaceController WorkspaceController_m { get; set; }
        public ApplicationContext ApplicationContext_m { get; set; }

        public void Starting(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        // Not Used States

        public void AddTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void Cancel(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void EditTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SaveTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SelectTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void UnselectTransaction(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }

        public void SwitchToState(ApplicationContext app_context_p)
        {
            throw new NotImplementedException();
        }
    }
}
