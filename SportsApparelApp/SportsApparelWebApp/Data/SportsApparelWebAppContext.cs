using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApparelApp.Entities.Entities;

namespace SportsApparelWebApp.Data
{
    public class SportsApparelWebAppContext : DbContext
    {
        public SportsApparelWebAppContext (DbContextOptions<SportsApparelWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<ApparelApp.Entities.Entities.Store> Store { get; set; }

        public DbSet<ApparelApp.Entities.Entities.Customer> Customer { get; set; }

        public DbSet<ApparelApp.Entities.Entities.Product> Product { get; set; }
    }
}
