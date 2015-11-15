using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain
{
    public class Product : DomainObject
    {
        public Product() { }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Author { get; set; }
        public virtual string Image { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int UnitsOnStock { get; set; }
        public virtual Category ProductCategory { get; set; }

        public virtual bool HasStock
        {
            get { return UnitsOnStock > 0; }
        }
    }
}
