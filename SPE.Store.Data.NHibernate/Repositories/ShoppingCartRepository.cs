using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate.Repositories
{
    public class ShoppingCartRepository : NHibernateRepository<Cart>, IShoppingCartRepository
    {
        public Domain.Cart GetActiveCart()
        {
            throw new NotImplementedException();
        }

        public void RemoveItemLine(int cartId, int itemLineId)
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
