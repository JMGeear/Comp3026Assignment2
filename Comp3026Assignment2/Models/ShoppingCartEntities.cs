using System.Data.Entity;

namespace Comp3026Assignment2.Models
{
    public class ShoppingCartEntities : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}