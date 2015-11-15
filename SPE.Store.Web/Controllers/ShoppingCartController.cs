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
        private ICatalogService _catalogService;

        public ShoppingCartController(IShoppingCartService shoppingCartService,
                                      ICatalogService catalogService) : base(shoppingCartService)
        {
            _catalogService = catalogService;
        }

        public ActionResult Index()
        {
            var cart = _shoppingCartService.GetActiveCart();
            Session["cart"] = cart;

            var cartViewModel = new ShoppingCartViewModel();
            
            if(cart != null)
            {
                cartViewModel.Id = cart.Id;
                cartViewModel.Lines = cart.Lines;
                cartViewModel.ItemInCart = cart.TotalQuantity;
            }
            
            return View(cartViewModel);
        }

        public ActionResult AddToCart(int productId)
        {
            var cart = Session["cart"] as Cart;
            var product = _catalogService.GetProduct(productId);
            _shoppingCartService.AddItem(cart, product, 1);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int productId)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Checkout()
        {
            _shoppingCartService.Checkout((Session["cart"] as Cart).Id);
            return RedirectToAction("Index", "Home");
        }
    }
}