using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain
{
    public class Cart
    {
        public Cart()
        {
            IsOrder = false;
            CreationDate = DateTime.Now;
        }

        public bool IsOrder { get; set; }
        public DateTime CreationDate { get; private set; }
        public IList<LineItem> Lines;
    }
}
