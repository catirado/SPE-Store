using NHibernate;
using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace SPE.Store.Data.NHibernate.Repositories
{
    public class ShoppingCartRepository : NHibernateRepository<Cart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(ISession session)
            : base(session)
        {
        }

        public Cart GetActiveCart()
        {
            return Transact(() => from cart in Session.Query<Cart>()
                                  where cart.IsOrder == false
                                  select cart).FirstOrDefault();
        }

        public void RemoveItemLine(int cartId, int itemLineId)
        {
            var line = new LineItem() { Id = itemLineId };
            Transact(() => Session.Delete(line));
        }

        public void AddItem(Cart cart, Product product, int quantity)
        {
            var line = new LineItem() { CartId = cart.Id, Price = product.Price, Quantity = quantity, ProductId = product.Id };
            Transact(() => Session.Save(line));
        }

        public void UpdateQuantity(Cart cart, Domain.Product product, int quantity)
        {
            var line = cart.Lines.Single<LineItem>(x => x.ProductId == product.Id);
            line.Quantity = line.Quantity + quantity;
            Transact(() => Session.Update(line));
        }
    }
}
