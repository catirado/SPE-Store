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
using NHibernate.Criterion;

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
            var query = Session.QueryOver<Product>()
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Future<Product>();

            var result = query.ToList();
            var rowcount = Session.QueryOver<Product>()
                        .Select(Projections.Count(Projections.Id()))
                        .FutureValue<int>().Value;

            return new Page<Product>()
            {
                Items = result,
                CurrentPage = page,
                ItemsPerPage = itemsPerPage,
                TotalItems = rowcount,
                TotalPages = rowcount / itemsPerPage
            };
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            return Transact(() => from products in Session.Query<Product>()
                                  where products.ProductCategory.Id == categoryId
                                  select products).ToList();
        }

        public IList<Product> GetMostPurchased(int numberOfResults)
        {
            /*var subquery = Session.Query<LineItem>()
                .Select(x => x.ProductId)
                .GroupBy<LineItem>(x => x.ProductId);
            */

            return Transact(() => from products in Session.Query<Product>()
                                  select products).ToList();
        }
    }
}
