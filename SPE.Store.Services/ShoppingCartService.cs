using SPE.Store.Domain.Repositories;
using SPE.Store.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public Domain.Cart GetActiveCart()
        {
            return _shoppingCartRepository.GetActiveCart();
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

        public void Checkout(int cartId)
        {
            throw new NotImplementedException();
        }
    }
}
