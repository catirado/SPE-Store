using NPoco.FluentMappings;
using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Mappings
{
    public class CategoryMap : Map<Category>
    {
        public CategoryMap()
        {
            Columns(x =>
            {
                x.Column(y => y.Id).WithAlias("Category_Id");
                x.Column(y => y.Name).WithAlias("Category_Name");
            });
        }
    }
}
