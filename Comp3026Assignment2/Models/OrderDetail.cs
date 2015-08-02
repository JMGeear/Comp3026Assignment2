namespace Comp3026Assignment2.Models
{
    using System.Data.Entity;

    public class OrderDetail : DbContext
    {
        public OrderDetail() : base("name=DefaultConnection")
        {
        }

        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Product OrderedProduct { get; set; }
        public virtual Order Order { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}