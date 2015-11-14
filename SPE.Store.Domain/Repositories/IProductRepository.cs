using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain.Repositories
{
    public interface IProductRepository
    {
        IPage<Product> GetProducts(int page, int itemsPerPage); 
        IList<Product> GetProductsByCategory(int categoryId);
        IList<Product> GetMostPurchased(int numberOfResults);
    }
}
