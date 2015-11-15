using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPE.Store.Services.Contracts
{
    public interface IShoppingCartService
    {
        Cart GetActiveCart();
        void AddItem(Cart cart, Product product, int quantity);
        void RemoveItemLine(int cartId, int itemLineId);
        void Checkout(Cart cart);
    }
}
