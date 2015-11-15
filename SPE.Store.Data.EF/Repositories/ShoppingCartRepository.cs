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

        public void RemoveItemLine(int cartId, int itemLineId)
        {
            throw new NotImplementedException();
        }

        public void EmptyCart(int cartId)
        {
            throw new NotImplementedException();
        }


        public void UpdateCartStatus(bool isOrder)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantity(int cartId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Domain.Cart GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Domain.Cart Add(Domain.Cart entity)
        {
            throw new NotImplementedException();
        }

        public Domain.Cart Update(Domain.Cart entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Domain.Cart entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }


        public Domain.Cart AddItem(Domain.Cart cart, Domain.Product product, int quantity)
        {
            throw new NotImplementedException();
        }


        void IShoppingCartRepository.AddItem(Domain.Cart cart, Domain.Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantity(Domain.Cart cart, Domain.Product product, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
