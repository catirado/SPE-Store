using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate
{
    public class NHibernateSessionFactory
    {
        public ISessionFactory GetSessionFactory()
        {
            ISessionFactory fluentConfiguration = Fluently.Configure()
                                                   .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString")))
                                                   .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SPE.Store.Domain.Product>())
                                                   .BuildSessionFactory();

            return fluentConfiguration;
        }
    }
}
