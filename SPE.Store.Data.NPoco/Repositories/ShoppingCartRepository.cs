using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Repositories
{
    public class ShoppingCartRepository : NPocoRepository<Cart>, IShoppingCartRepository
    {
        public Cart GetActiveCart()
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                return db.Fetch<Cart, LineItem>(
                    new global::NPoco.Sql()
                    .Select("c.*", "l.*")
                    .From("Carts c")
                    .LeftJoin("LineItems l")
                    .On("c.Id = l.CartId")
                    .Where("c.Confirmed = 0"))
                    .FirstOrDefault();
            }
        }

        public Cart AddItem(int cartId, int productId, int quantity)
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
