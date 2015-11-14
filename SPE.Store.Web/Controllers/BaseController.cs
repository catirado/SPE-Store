using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPE.Store.Web.Controllers
{
    public class BaseController : Controller
    {
        protected int GetItemsInCart()
        {
            if (Session["cart"] == null)
            {
                return 0;
            }
            else
            {
                var cart = Session["cart"] as Cart;
                return cart.Lines.Sum(x => x.Quantity);
            }
        }

    }
}