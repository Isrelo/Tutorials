using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;
using TransactionRegister.Models;

namespace TransactionRegister.ViewModels
{
    public class TransactionViewModel : BaseModel
    {
        public bool IsCredit { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
        public String Description { get; set; }
        public Brush Font_Color { get; set; }

        public TransactionViewModel()
        {
            IsCredit = false;
            Amount = 0;
            Balance = 0;
            Description = "";
            Font_Color = Brushes.Black;
        }
    }
}
