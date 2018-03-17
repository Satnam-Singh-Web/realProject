using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StockStimulationWebApp.Models
{
    public class ShareDataContext:DbContext
    {
        public DbSet<companyShares> companyShares { get; set;  }
        public DbSet<signUp> Signup { get; set; }
        public DbSet<Login> Logins { get; set; }
        public ShareDataContext(DbContextOptions<ShareDataContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
