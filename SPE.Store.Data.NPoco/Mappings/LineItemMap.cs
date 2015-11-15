using NPoco.FluentMappings;
using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Mappings
{
    public class LineItemMap : Map<LineItem>
    {
        public LineItemMap()
        {
            Columns(x =>
            {
                x.Column(y => y.Amount).Ignore();
            });
        }
    }
}
