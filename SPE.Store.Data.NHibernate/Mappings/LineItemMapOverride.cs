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
    public class LineItemMapOverride : IAutoMappingOverride<LineItem>
    {
        public void Override(AutoMapping<LineItem> mapping)
        {
            mapping.IgnoreProperty(x => x.Amount);
            
            /*mapping.References<Product>(x => x.ProductName, "Name")
                    .Column("ProductId")
                    .ReadOnly();*/

            mapping.Join("Products", join =>
            {
                join.Fetch.Join();
                join.KeyColumn("Id");
                join.Map(prop => prop.ProductName).Column("Name");//.Not.Nullable().ReadOnly();
                join.Inverse();
            });
        }
    }
}
