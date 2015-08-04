using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp3026Assignment2.Models;
using Comp3026Assignment2.ViewModels;
using Comp3026Assignment2.Services;

namespace Comp3026Assignment2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private VirtuosoModels db = new VirtuosoModels();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = ShoppingCartService.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }

        //
        // GET: /Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            // Retrieve the Product from the database
            var addedProduct = db.Products
                .SingleOrDefault(product => product.ProductID == id);

            // Add it to the shopping cart
            var cart = ShoppingCartService.GetCart(this.HttpContext);

            cart.AddToCart(addedProduct);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = ShoppingCartService.GetCart(this.HttpContext);

            // Get the name of the product to display confirmation
            string albumName = db.Cart
                .SingleOrDefault(item => item.RecordID == id).Product.Name;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(albumName) +
                    " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        //
        // GET: /ShoppingCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCartService.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}