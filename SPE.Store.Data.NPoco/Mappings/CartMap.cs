using NPoco.FluentMappings;
using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Mappings
{
    public class CartMap : Map<Cart>
    {
        public CartMap()
        {
            Columns(x =>
            {
                x.Column(y => y.IsOrder).WithName("Confirmed");
                x.Column(y => y.Lines).Result();
                x.Column(y => y.TotalAmount).Ignore();
                x.Column(y => y.TotalQuantity).Ignore();
            });
        }
    }
}
