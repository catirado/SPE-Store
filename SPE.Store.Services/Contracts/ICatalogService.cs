using SPE.Store.Domain;
using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPE.Store.Services.Contracts
{
    public interface ICatalogService
    {
        Product GetProduct(int id);
        IList<Product> GetMostPurchased();
        IList<Product> GetProductsOfCategory(int categoryId);
        IList<Category> GetCategories();
        IPage<Product> GetProducts(int page, int itemsPerPage);
    }
}
