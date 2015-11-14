using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Repositories
{
    public class ProductRepository : NPocoRepository<Product>, IProductRepository
    {
        public IPage<Product> GetProducts(int page, int itemsPerPage)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                var pages = db.Page<Product>(page, itemsPerPage, "");
                return null;
            }
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                return db.FetchBy<Product>(sql => sql.Where(x => x.ProductCategory.Id == categoryId));
            }
        }

        public IList<Product> GetMostPurchased(int numberOfResults)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                return db.Fetch<Product>().Take<Product>(4).ToList();
            }
        }
    }
}
