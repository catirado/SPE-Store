using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain.Repositories
{
    public interface IShoppingCartRepository
    {
        Cart GetActiveCart();
        Cart AddItem(int cartId, int productId, int quantity);
        void RemoveItemLine(int cartId, int itemLineId);
        void EmptyCart(int cartId);
    }
}
