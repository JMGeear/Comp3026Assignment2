namespace Comp3026Assignment2.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Cart
    {
        [Key]
        public int RecordID { get; set; }
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Product ProductItem  { get; set; }
    }
}