using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPE.Store.Web.Models
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public IList<LineItem> Lines {get; set;}
    }
}