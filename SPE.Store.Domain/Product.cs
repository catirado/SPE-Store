using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string PublicationDate { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int UnitsOnStock { get; set; }
        public IList<Category> Categories { get; set; }

        public bool HasStock
        {
            get { return UnitsOnStock > 0; }
        }
    }
}
