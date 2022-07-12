using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db
{
    internal class EcommerceContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrdersProducts> OrdersProducts { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=csharp-ecommerce;Integrated Security=True");
        }
    }
}
