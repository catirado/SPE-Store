using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SPE.Store.Data.NHibernate.Mappings;
using SPE.Store.Data.NHibernate.Mappings.Conventions;
using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate
{
    public class NHibernateSessionFactory
    {
        public ISessionFactory GetSessionFactory(string connection)
        {
            var model = new AutoPersistenceModel()
                        .AddEntityAssembly(typeof(Product).Assembly)
                        .Where(t => t.Namespace.StartsWith(typeof(Product).Namespace))
                        .Conventions.AddFromAssemblyOf<TableNameConvention>()
                        .UseOverridesFromAssemblyOf<CartMapOverride>();

            ISessionFactory fluentConfiguration = Fluently.Configure()
                                                   .Database(MsSqlConfiguration.MsSql2012
                                                            .ConnectionString(c => c.FromConnectionStringWithKey(connection))
                                                            .ShowSql())
                                                   .Mappings(m => m.AutoMappings.Add(model))
                                                   .BuildSessionFactory();

            return fluentConfiguration;
        }
    }
}
