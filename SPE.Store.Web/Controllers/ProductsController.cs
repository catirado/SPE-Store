using SPE.Store.Services.Contracts;
using SPE.Store.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Omu.ValueInjecter;
using MvcContrib.Pagination;

namespace SPE.Store.Web.Controllers
{
    public class ProductsController : BaseController
    {
        private const int NUM_PRODUCTS_PER_PAGE = 6;
        private ICatalogService _catalogService;

        public ProductsController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public ActionResult Index(int? page)
        {
            var products = _catalogService.GetProducts(page ?? 1, NUM_PRODUCTS_PER_PAGE);

            var paged = new CustomPagination<ProductListViewModel>(
                products.Items.Select(
                        x => new ProductListViewModel().InjectFrom(x) as ProductListViewModel)
                        .ToList(),
               (int)products.CurrentPage,
               (int)products.ItemsPerPage,
               (int)products.TotalItems);

            var productsViewModel = new PagedProductsListViewModel()
            {
                ItemInCart = GetItemsInCart(),
                Products = paged
            };
            return View(productsViewModel);
        }

    }
}
