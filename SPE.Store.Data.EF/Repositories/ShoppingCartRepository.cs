using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.EF.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {

        public Domain.Cart GetActiveCart()
        {
            throw new NotImplementedException();
        }

        public Domain.Cart AddItem(int cartId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveItemLine(int cartId, int itemLineId)
        {
            throw new NotImplementedException();
        }

        public void EmptyCart(int cartId)
        {
            throw new NotImplementedException();
        }
    }
}
