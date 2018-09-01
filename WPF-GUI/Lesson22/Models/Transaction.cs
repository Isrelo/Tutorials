using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TransactionRegister.Models
{
    public class Transaction : BaseModel, INotifyPropertyChanged
    {
        private String description_m;
        public String Description
        {
            get { return description_m; }
            set
            {
                description_m = value;

                // Required Changed Event
                NotifyPropertyChanged();
            }
        }
        private double balance_m;
        public double Balance
        {
            get { return balance_m; }
            set
            {
                balance_m = value;

                // Required Changed Event
                NotifyPropertyChanged();
            }
        }
        private bool debit_or_credit_m;
        public bool DebitOrCredit
        {
            get { return debit_or_credit_m; }
            set
            {
                debit_or_credit_m = value;

                // Required Changed Event
                NotifyPropertyChanged();
            }
        }
        private double amount_m;
        public double Amount
        {
            get { return amount_m; }
            set
            {
                amount_m = value;

                // Required Changed Event
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
