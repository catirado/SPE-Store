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
            var existingLine = cart.Lines.SingleOrDefault(x => x.ProductId == product.Id);
            if (existingLine != null)
            {
                _shoppingCartRepository.UpdateQuantity(cart, product, quantity);
            }
            else
            {
                _shoppingCartRepository.AddItem(cart, product, quantity);
            }
        }

        public void RemoveItemLine(int cartId, int itemLineId)
        {
            _shoppingCartRepository.RemoveItemLine(cartId, itemLineId);
        }

        public void Checkout(Cart cart)
        {
            cart.IsOrder = true;
            _shoppingCartRepository.Update(cart);
        }

    }
}
