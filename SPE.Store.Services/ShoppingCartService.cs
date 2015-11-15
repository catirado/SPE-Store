using SPE.Store.Domain;
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
            var cart = _shoppingCartRepository.GetActiveCart();
            if (cart == null)
            {
                Cart newCart = new Cart();
                return _shoppingCartRepository.Add(newCart);
            }
            return cart;
        }

        public void AddItem(Cart cart, Product product, int quantity)
        {
            //update quantity
            //if exists add, else update
            //_shoppingCartRepository.UpdateQuantity(cart, product, quantity);
            _shoppingCartRepository.AddItem(cart, product, quantity);

        }

        public void RemoveItemLine(int cartId, int itemLineId)
        {
            _shoppingCartRepository.RemoveItemLine(cartId, itemLineId);
        }

        public void EmptyCart(int cartId)
        {
            _shoppingCartRepository.EmptyCart(cartId);
        }

        public void Checkout(int cartId)
        {
            bool isOrder = true;
            _shoppingCartRepository.UpdateCartStatus(isOrder);
        }

    }
}
