using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;
using NPoco.FluentMappings;

namespace SPE.Store.Data.NPoco
{
    public static class NPocoDataBaseFactory
    {
        private const string DATABASE_CONNECTION_STRING = "DefaultConnection";

        public static DatabaseFactory DbFactory { get; set; }

        public static void Setup()
        {
            var fluentConfig = FluentMappingConfiguration.Configure(
                    //new CampaingMap()
                    //mappings + conventions
                );

            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => new Database(DATABASE_CONNECTION_STRING));
                x.WithFluentConfig(fluentConfig);
            });
        }
    }
}
