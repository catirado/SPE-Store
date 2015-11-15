using SPE.Store.Domain;
using SPE.Store.Services.Contracts;
using SPE.Store.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPE.Store.Web.Controllers
{
    public class ShoppingCartController : BaseController
    {
        private IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public ActionResult Index()
        {
            var cart = _shoppingCartService.GetActiveCart();
            Session["cart"] = cart;
            var cartViewModel = new ShoppingCartViewModel()
            {
                Id = cart.Id,
                Lines = cart.Lines,
                ItemInCart = cart.TotalQuantity
            };

            return View(cartViewModel);
        }

        //cualquier cosa que añada la mando al index y le meto en seguir comprando

        public ActionResult AddToCart(int productId)
        {
            var cart = Session["cart"] as Cart;
            _shoppingCartService.AddItem(cart.Id, productId, 1);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int productId)
        {

            return RedirectToAction("Index");
        }

        public ActionResult EmptyCart()
        {

            return RedirectToAction("Index");
        }

        public ActionResult Checkout()
        {

            return RedirectToAction("Index");
        }
    }
}