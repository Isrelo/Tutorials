using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using TransactionRegister.ViewModels;

namespace TransactionRegister
{
    public class Utilities
    {
        public static double CalcualteBalance(BindingList<TransactionViewModel> transactions_p)
        {
            double current_balance = 0.00;

            for(int count = 0; count < transactions_p.Count; count++)
            {
                TransactionViewModel transaction = transactions_p[count];

                if(transaction.IsCredit)
                {
                    // This is a credit trans.
                    current_balance += transaction.Amount;
                }
                else
                {
                    // This is a debit trans.
                    current_balance -= transaction.Amount;
                }

                // Recording the current balance.
                transaction.Balance = current_balance;
            }

            return current_balance;
        }
    }
}
