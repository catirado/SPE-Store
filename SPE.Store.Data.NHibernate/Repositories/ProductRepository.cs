using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate.Repositories
{
    public class ProductRepository : NHibernateRepository<Product>, IProductRepository
    {
        public IPage<Product> GetProducts(int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetMostPurchased(int numberOfResults)
        {
            throw new NotImplementedException();
        }
    }
}
