using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain
{
    public class Cart : DomainObject
    {
        public Cart()
        {
            IsOrder = false;
            CreationDate = DateTime.Now;
            Lines = new List<LineItem>();
        }

        public virtual bool IsOrder { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual IList<LineItem> Lines { get; set; }

        public virtual int TotalQuantity { get { return Lines.Sum(x => x.Quantity); } }
        public virtual decimal TotalAmount { get { return Lines.Sum(x => x.Amount); } }

    }
}
