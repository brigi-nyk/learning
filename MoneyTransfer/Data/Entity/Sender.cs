using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data.Entity
{
    public class Sender
    {
        [Key]
        public long Cnp { get; set; }
        public short Age { get; set; }

    }
}
