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
        public Cart() // is ok for ORMs?¿
        {
            IsOrder = false;
            CreationDate = DateTime.Now;
        }

        public void AddItem(int productId)
        {
            //if exists add
        }

        public virtual bool IsOrder { get; set; }
        public virtual DateTime CreationDate { get; private set; }
        public IList<LineItem> Lines;

        //total price
        //total quantity
    }
}
