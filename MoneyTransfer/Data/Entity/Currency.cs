using MoneyTransfer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data.Entity
{
    public enum CurrencyEnum
    {
        USD,
        EUR,
        RON,
        GBP
    }
    public class Currency
    {
        
        private Currency(CurrencyEnum @enum)
        {
            ID = (int)@enum;
            Name = @enum.ToString();
            Description = @enum.GetEnumDescription();
        }


        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
