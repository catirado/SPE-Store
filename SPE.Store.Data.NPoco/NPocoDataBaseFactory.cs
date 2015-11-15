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
        private const string DATABASE_CONNECTION_STRING = "DefaultConnection";

        public static DatabaseFactory DbFactory { get; set; }

        public static void Setup()
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
                x.UsingDatabase(() => new Database(DATABASE_CONNECTION_STRING));
                x.WithFluentConfig(conventions);
            });
        }
    }
}
