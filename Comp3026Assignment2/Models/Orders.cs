namespace Comp3026Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orders")]
    public partial class Orders
    {
        [Key]
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int CustomerID { get; set; }

        public decimal Price { get; set; }

        public virtual Customer Customers { get; set; }

        public virtual Product Products { get; set; }
    }
}
