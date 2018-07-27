using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;

namespace TransactionRegister.States
{
    public interface IState
    {
        void Starting(ApplicationContext app_context_p);
        void AddTransaction(ApplicationContext app_context_p);
        void EditTransaction(ApplicationContext app_context_p);
        void SaveTransaction(ApplicationContext app_context_p);
        void Cancel(ApplicationContext app_context_p);
        void SelectTransaction(ApplicationContext app_context_p);
        void UnselectTransaction(ApplicationContext app_context_p);
        void DeleteTransaction(ApplicationContext app_context_p);
    }
}
