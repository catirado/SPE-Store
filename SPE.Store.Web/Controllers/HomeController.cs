using SPE.Store.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPE.Store.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICatalogService _catalogService;

        public HomeController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public ActionResult Index()
        {
            var products = _catalogService.GetMostPurchased();

            return View();
        }

    }
}