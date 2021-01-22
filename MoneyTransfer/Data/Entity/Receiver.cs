using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data.Entity
{
    public class Receiver
    {
        [Key]
        public int ID { get; set; }
        public string IBAN { get; set; }
        public string Country { get; set; }
    }
}
