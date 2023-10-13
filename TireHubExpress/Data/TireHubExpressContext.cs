using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TireHubExpress.Models;

namespace TireHubExpress.Data
{
    public class TireHubExpressContext : DbContext
    {
        public TireHubExpressContext (DbContextOptions<TireHubExpressContext> options)
            : base(options)
        {
        }

        public DbSet<TireHubExpress.Models.Tire> Tire { get; set; }

      
    }
}

