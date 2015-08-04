namespace Comp3026Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int BrandID { get; set; }

        public string image { get; set; }

        public virtual Brands Brands { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
