using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TransactionRegister
{
    public partial class Transaction
    {
        public String transAmount_m;
        public DateTime transDate_m;
        public String transDesc_m;
        public String checkNum_m;
        public bool debitOrCredit_m;
        public bool isACheck_m;
    }
}