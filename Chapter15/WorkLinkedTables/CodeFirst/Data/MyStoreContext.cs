using Microsoft.EntityFrameworkCore;

using CodeFirst.Models;

namespace CodeFirst.Data
{
    internal class MyStoreContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=efcoresamples;Trusted_Connection=True;");
        }
    }
}
