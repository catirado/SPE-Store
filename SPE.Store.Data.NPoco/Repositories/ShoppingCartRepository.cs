using SPE.Store.Data.NPoco.Mappings;
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
                return db.Fetch<Cart, LineItem, Cart>
                    (new CartLineItemRelator().MapIt,
                    new global::NPoco.Sql()
                    .Select("c.*", "l.*","p.Name as ProductName")
                    .From("Carts c")
                    .LeftJoin("LineItems l")
                    .On("c.Id = l.CartId")
                    .LeftJoin("Products p")
                    .On("l.ProductId = p.Id")
                    .Where("c.Confirmed = 0"))
                    .FirstOrDefault();
            }
        }

        public void AddItem(Cart cart, Product product, int quantity)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                db.Insert<LineItem>(new LineItem() { CartId = cart.Id, Price = product.Price, Quantity = quantity, ProductId = product.Id });
            }
        }

        public void RemoveItemLine(int cartId, int itemLineId)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                db.Delete(new LineItem(){Id = itemLineId });
            }
        }

        public void UpdateQuantity(Cart cart, Product product, int quantity)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                var line = cart.Lines.Single<LineItem>(x => x.ProductId == product.Id);
                line.Quantity = line.Quantity + quantity;
                db.Update(line);
            }
        }
    }
}
