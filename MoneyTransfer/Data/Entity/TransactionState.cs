using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data.Entity
{
    public enum State
    { 
        newTransaction,
        pending,
        complete,
        canceled,
        delete
    }
    public class TransactionState
    {
    }
}
