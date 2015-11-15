using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain.Repositories
{
    public interface IShoppingCartRepository : IRepository<Cart>
    {
        Cart GetActiveCart();
        void AddItem(Cart cart, Product product, int quantity);
        void UpdateQuantity(Cart cart, Product product, int quantity);
        void RemoveItemLine(int cartId, int itemLineId);
    }
}
