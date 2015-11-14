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
        public int ProductId;
        public int Quantity;
        public decimal Amount;
    }
}
