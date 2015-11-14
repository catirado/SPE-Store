using SPE.Store.Domain;
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
    public class CategoriesController : BaseController
    {
        private ICatalogService _catalogService;

        public CategoriesController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public ActionResult Index()
        {
            var categories = _catalogService.GetCategories();
            var categoriesViewModel = new CategoriesListViewModel()
            {
                ItemInCart = GetItemsInCart(),
                Categories = categories.Select(
                        x => new CategoryListViewModel().InjectFrom(x) as CategoryListViewModel)
                        .ToList()
            };
            return View(categoriesViewModel);
        }

        public ActionResult Category(int categoryId)
        {
            var products = _catalogService.GetProductsOfCategory(categoryId);
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