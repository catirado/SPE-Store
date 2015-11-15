using SPE.Store.Domain;
using SPE.Store.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPE.Store.Web.Controllers
{
    public class BaseController : Controller
    {
        protected IShoppingCartService _shoppingCartService;

        public BaseController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        protected int GetItemsInCart()
        {
            if (Session["cart"] == null)
            {
                var cart = _shoppingCartService.GetActiveCart();
                return cart.TotalQuantity;
            }
            else
            {
                var cart = Session["cart"] as Cart;
                return cart.TotalQuantity;
            }
        }
    }
}