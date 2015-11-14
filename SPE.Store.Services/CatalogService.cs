using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPE.Store.Services.Contracts;
using SPE.Store.Domain.Repositories;
using SPE.Store.Domain;
using SPE.Store.Infrastructure.Domain;

namespace SPE.Store.Services
{
    public class CatalogService : ICatalogService
    {
        private const int NUM_MOST_PURCHASED = 4;

        private IProductRepository _productRepository;

        public CatalogService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IPage<Product> GetProducts()
        {
            var products = _productRepository.GetProducts(1, 100);
            return products;
        }


        //get categories

        //get products by category

        //get products

        //get favourites

        public IList<Product> GetMostPurchased()
        {
            return _productRepository.GetMostPurchased(NUM_MOST_PURCHASED);
        }
    }
}
