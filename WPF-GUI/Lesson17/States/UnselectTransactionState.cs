﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransactionRegister.Contexts;

namespace TransactionRegister.States
{
    public class UnselectTransactionState : State
    {
        public override void Starting(ApplicationContext app_context_p)
        {
            base.Starting(app_context_p);
        }
    }
}
