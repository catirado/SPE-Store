using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain.Repositories
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        IList<Product> GetAllProducts(); //paginated
        IList<Product> GetProductsByCategory(); //paginated
        IList<Product> GetMostPurchased(); //paginated
    }
}
