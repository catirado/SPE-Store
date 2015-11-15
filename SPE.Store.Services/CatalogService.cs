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
        private const int NUM_MOST_PURCHASED = 3;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public CatalogService(IProductRepository productRepository, 
                              ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public Product GetProduct(int id)
        {
            return _productRepository.GetById(id);
        }

        public IPage<Product> GetProducts(int page, int itemsPerPage)
        {
            var products = _productRepository.GetProducts(page, itemsPerPage);
            return products;
        }

        public IList<Product> GetMostPurchased()
        {
            return _productRepository.GetMostPurchased(NUM_MOST_PURCHASED);
        }

        public IList<Product> GetProductsOfCategory(int categoryId)
        {
            return _productRepository.GetProductsByCategory(categoryId);
        }

        public IList<Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }

    }
}
