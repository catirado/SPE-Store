using SPE.Store.Services.Contracts;
using SPE.Store.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Omu.ValueInjecter;

namespace SPE.Store.Web.Controllers
{
    public class HomeController : BaseController
    {
        private ICatalogService _catalogService;

        public HomeController(IShoppingCartService shoppingCartService,
                                      ICatalogService catalogService) : base(shoppingCartService)
        {
            _catalogService = catalogService;
        }

        public ActionResult Index()
        {
            var products = _catalogService.GetMostPurchased();
            var productsViewModel = new ProductsListViewModel()
            {
                ItemInCart = GetItemsInCart(),
                Products = products.Select(
                        x => new ProductListViewModel().InjectFrom(x) as ProductListViewModel)
                        .ToList()
            };
            return View(productsViewModel);
        }

    }
}