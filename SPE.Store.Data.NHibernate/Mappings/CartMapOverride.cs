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
    public class CartMapOverride : IAutoMappingOverride<Cart>
    {
        public void Override(AutoMapping<Cart> mapping)
        {
            mapping.IgnoreProperty(x => x.TotalAmount);
            mapping.IgnoreProperty(x => x.TotalQuantity);
            mapping.Map(x => x.IsOrder).Column("Confirmed");

            mapping.HasMany(x => x.Lines)
                .AsBag()
                .Cascade
                .AllDeleteOrphan()
                .KeyColumn("CartId");

        }
    }
}
