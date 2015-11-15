using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate.Mappings
{
    public class ProductMapOverride : IAutoMappingOverride<Product>
    {
        public void Override(AutoMapping<Product> mapping)
        {
            mapping.IgnoreProperty(x => x.HasStock);
            mapping.Map(x => x.UnitsOnStock).Column("Stock");
            mapping.References<Category>(x => x.ProductCategory).Column("CategoryId");
        }
    }
}
