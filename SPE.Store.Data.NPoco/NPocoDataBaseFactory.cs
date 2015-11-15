using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;
using NPoco.FluentMappings;
using SPE.Store.Domain;
using SPE.Store.Data.NPoco.Mappings;

namespace SPE.Store.Data.NPoco
{
    public static class NPocoDataBaseFactory
    {
        public static DatabaseFactory DbFactory { get; set; }

        public static void Setup(string connection)
        {
            var conventions = FluentMappingConfiguration.Scan(scanner =>
            {
                scanner.Assembly(typeof(Product).Assembly);
                scanner.IncludeTypes(x => x.Namespace.StartsWith(typeof(Product).Namespace));
                scanner.TablesNamed(x => Inflector.MakePlural(x.Name));
                scanner.PrimaryKeysNamed(x => "Id");
                scanner.OverrideMappingsWith(new IMap[] {
                            new ProductMap(), 
                            new CategoryMap(), 
                            new LineItemMap(), 
                            new CartMap()});
            });

            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => new Database(connection));
                x.WithFluentConfig(conventions);
            });
        }
    }
}
