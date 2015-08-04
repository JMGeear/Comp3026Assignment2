namespace Comp3026Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int BrandID { get; set; }

        public string image { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
