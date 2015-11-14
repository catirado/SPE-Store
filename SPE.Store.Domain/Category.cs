using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain
{
    public class Category : DomainObject
    {
        public string Name { get; set; }
        public IList<Product> Products { get; set; }
    }
}
