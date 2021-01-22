using Microsoft.EntityFrameworkCore;
using MoneyTransfer.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data
{
    public class MoneyTransferContext : DbContext
    {
        public MoneyTransferContext(DbContextOptions<MoneyTransferContext> option)
            :base(option)
        {
        }

        //public DbSet<Sender> Senders { get; set; }
        //public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

    }
}
