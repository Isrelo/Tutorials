﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using TransactionRegister.Contexts;
using TransactionRegister.ViewModels;
using TransactionRegister.Controllers;

namespace TransactionRegister.States
{
    public interface IState
    {
        BindingList<TransactionViewModel> Transactions_m { get; set; }
        ToolbarController ToolbarController_m { get; set; }
        WorkspaceController WorkspaceController_m { get; set; }
        ApplicationContext ApplicationContext_m { get; set; }

        void SwitchToState(ApplicationContext app_context_p);
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