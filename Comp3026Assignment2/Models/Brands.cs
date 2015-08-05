namespace Comp3026Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brands")]
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int BrandID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Brand Name")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
