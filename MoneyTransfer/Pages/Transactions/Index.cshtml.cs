using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoneyTransfer.Data;
using MoneyTransfer.Data.Entity;

namespace MoneyTransfer
{
    public class IndexModel : PageModel
    {
        private readonly MoneyTransfer.Data.MoneyTransferContext _context;

        public IndexModel(MoneyTransfer.Data.MoneyTransferContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; }

        public async Task OnGetAsync()
        {
            Transaction = await _context.Transactions.ToListAsync();
        }
    }
}
