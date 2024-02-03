using Microsoft.EntityFrameworkCore;

using CodeFirst.Models;
using Microsoft.Extensions.Logging;

namespace CodeFirst.Data
{
    internal class MyStoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }))
                .UseSqlServer("Data Source=.;Initial Catalog=efcoresample;uid=sa;pwd=Hujkq23&6#;Trust Server Certificate=true;");
            //                .UseSqlServer("Data Source=.;Initial Catalog=efcoresample;Integrated Security=true;Trust Server Certificate=true;");
        }
    }

    internal class MyStoreContextReadOnly : MyStoreContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
   }
}
