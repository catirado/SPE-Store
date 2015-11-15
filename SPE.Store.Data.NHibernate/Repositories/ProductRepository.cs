using NHibernate;
using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace SPE.Store.Data.NHibernate.Repositories
{
    public class ProductRepository : NHibernateRepository<Product>, IProductRepository
    {
        public ProductRepository(ISession session)
            : base(session)
        {
        }

        public IPage<Product> GetProducts(int page, int itemsPerPage)
        {

            throw new NotImplementedException();
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            return Transact(() => from products in Session.Query<Product>()
                                  where products.ProductCategory.Id == categoryId
                                  select products).ToList();
        }

        public IList<Product> GetMostPurchased(int numberOfResults)
        {
            return Transact(() => from products in Session.Query<Product>()
                                  select products).ToList();
        }
    }
}
