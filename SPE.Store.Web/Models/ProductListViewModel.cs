using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPE.Store.Web.Models
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool HasStock { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
