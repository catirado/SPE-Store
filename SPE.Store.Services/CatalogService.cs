using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPE.Store.Services.Contracts;
using SPE.Store.Domain.Repositories;

namespace SPE.Store.Services
{
    public class CatalogService : ICatalogService
    {
        private IProductRepository _productRepository;

        public CatalogService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //get categories

        //get products by category

        //get products

        //get favourites
    }
}
