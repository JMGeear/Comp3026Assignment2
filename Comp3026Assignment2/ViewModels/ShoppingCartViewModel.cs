

namespace Comp3026Assignment2.ViewModels
{
    using System.Collections.Generic;
    using Models;

    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}