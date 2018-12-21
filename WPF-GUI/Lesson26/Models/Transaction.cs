using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TransactionRegister.Models
{
    public class Transaction : BaseModel
    {
        public bool DebitOrCredit { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
        public String Description { get; set; }               
    }
}
