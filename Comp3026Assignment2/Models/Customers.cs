namespace Comp3026Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers")]
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [Required]
        public byte[] Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime PurchaceDate { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
