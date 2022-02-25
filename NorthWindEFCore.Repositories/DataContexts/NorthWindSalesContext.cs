using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFCore.Repositories.DataContexts
{
    public class NorthWindSalesContext : DbContext
    {
      
        public NorthWindSalesContext(DbContextOptions<NorthWindSalesContext> options):base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }    
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
