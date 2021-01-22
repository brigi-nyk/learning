using MoneyTransfer.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Models
{
    public class TransactionViewModel
    {
        [Required]
        [MinLength(13, ErrorMessage = "Too Short")]
        [MaxLength(13, ErrorMessage = "Too Long")]
        public string CNP { get; set; }

        [Required]
        [MinLength(15, ErrorMessage = "Too Short")]
        [MaxLength(32, ErrorMessage = "Too Long")]
        public string IBAN { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Need a bigger amount!")]
        public decimal Amount { get; set; }

        [Required]
        public CurrencyEnum SenderCurrency { get; set; }

        [Required]
        public CurrencyEnum ReceiverCurrency { get; set; }
    }
}
