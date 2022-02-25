using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFCore.Repositories.DataContexts
{
    internal class NorthWindContext : DbContext
    {
        //Add-Migration InitialCreate -p NorthWindEFCore.Repositories -s NorthWindEFCore.Repositories -c NorthWindContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database = NorthWindNET20");
        }

        public DbSet<Order> Orders { get; set; }    
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
