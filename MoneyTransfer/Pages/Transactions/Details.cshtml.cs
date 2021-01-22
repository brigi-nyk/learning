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
    public class DetailsModel : PageModel
    {
        private readonly MoneyTransfer.Data.MoneyTransferContext _context;

        public DetailsModel(MoneyTransfer.Data.MoneyTransferContext context)
        {
            _context = context;
        }

        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transaction = await _context.Transactions.FirstOrDefaultAsync(m => m.Id_Transaction == id);

            if (Transaction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
