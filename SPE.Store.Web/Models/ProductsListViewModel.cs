using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPE.Store.Web.Models
{
    public class ProductsListViewModel : BaseViewModel
    {
        public IList<ProductListViewModel> Products { get; set; }
    }
}