﻿using NPoco.FluentMappings;
using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Mappings
{
    public class ProductMap : Map<Product>
    {
        public ProductMap()
        {
            Columns(x =>
            {
                x.Column(y => y.UnitsOnStock).WithName("Stock");
                x.Column(y => y.ProductCategory).Ignore().Result();
                x.Column(y => y.HasStock).Ignore();
            });
        }
    }
}
