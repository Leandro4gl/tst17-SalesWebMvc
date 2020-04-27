using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tst17_SalesWebMvc.Models;

namespace tst17_SalesWebMvc.Data
{
    public class tst17_SalesWebMvcContext : DbContext
    {
        public tst17_SalesWebMvcContext (DbContextOptions<tst17_SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
