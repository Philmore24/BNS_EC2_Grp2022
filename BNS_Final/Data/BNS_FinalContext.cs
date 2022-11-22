using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BNS_Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BNS_Final.Data
{
    public class BNS_FinalContext : IdentityDbContext<ApplicationUser>
    {
        public BNS_FinalContext()
        {

        }
        public BNS_FinalContext (DbContextOptions<BNS_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Teller> Teller { get; set; }

        public DbSet<Transaction> accountTransaction { get; set; }

    }
}
