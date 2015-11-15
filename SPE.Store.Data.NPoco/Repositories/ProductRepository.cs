using SPE.Store.Data.NPoco.Adapters;
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
                //we need to use alias for avoid error of duplicated Id and Name field
                var query = new global::NPoco.Sql()
                        .Select("p.*", "c.Id as Category_Id", "c.Name as Category_Name")
                        .From("products p")
                        .LeftJoin("categories c")
                        .On("p.CategoryId = c.Id");

               var pages = db.Page<Product, Category>(
                    page, 
                    itemsPerPage,
                    query);

               return PageAdapterFactory<Product>.CreateAdapter(pages);
            }
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                return db.Fetch<Product, Category>(
                    new global::NPoco.Sql()
                    .Select("p.*","c.*")
                    .From("products p")
                    .LeftJoin("categories c")
                    .On("p.CategoryId = c.Id")
                    .Where("p.CategoryId = @0", categoryId))
                    .ToList();
            }
        }

        public IList<Product> GetMostPurchased(int numberOfResults)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                var query = new global::NPoco.Sql()
                    .Select("p.*", "c.*")
                    .From("products p")
                    .LeftJoin("categories c")
                    .On("p.CategoryId = c.Id");

                return db.Fetch<Product, Category>(
                    query)
                    .Take<Product>(numberOfResults).ToList();
            }
        }
    }
}
