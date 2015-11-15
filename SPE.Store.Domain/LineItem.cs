using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain
{
    public class LineItem : DomainObject
    {
        public virtual int CartId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string ProductName { get; set; }
        public virtual decimal Amount { get { return Price * Quantity; } }
    }
}
