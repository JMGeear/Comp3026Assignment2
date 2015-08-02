using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Comp3026Assignment2.Models
{
    public class ShoppingCartEntities : DbContext
    {
        public ShoppingCartEntities() : base("name=virtuoso")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}