using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.States;

namespace TransactionRegister.Contexts
{
    public class ApplicationContext
    {
        public State CurrentState_m { get; set; }

        public ApplicationContext(State state_to_switch_to_p)
        {
            CurrentState_m = state_to_switch_to_p;
        }
    }
}
