using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data.Entity
{
    public class Transaction
    {
        [Key]
        public int Id_Transaction { get; set; }

        public int Id_Sender { get; set; }
        public Sender sender { get; set; }
        public int Amount_Sender { get; set; }
        public CurrencyEnum Currency_Sender { get; set; }
        public int Id_Receiver { get; set; }
        public Receiver receiver { get; set; }
        public int Amount_Receiver { get; set; }
        public CurrencyEnum Currency_Receiver { get; set; }
        public string Token { get; set; }
        public State Transaction_State { get; set; }

        [DataType(DataType.Date)]
        public DateTime Transaction_Date { get; set; }
    }
}
