using Ninject.Modules;
using SPE.Store.Infrastructure.Bootstrap.Database;
using SPE.Store.Infrastructure.Bootstrap.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Bootstrap
{
    public static class BootstrapFactory
    {
        public static void AppStartSetup(string orm, string connection)
        {
            if (orm == "NPoco")
                NPocoDatabaseSetup.Setup(connection);
        }

        public static IList<NinjectModule> GetModules(string orm, string connection)
        {
            var modules = new List<NinjectModule>();
            modules.Add(new ServicesModule());
            if (orm == "NPoco")
                modules.Add(new NPocoRepositoriesModule());
            if (orm == "NHibernate")
            {
                modules.Add(new NHibernateRepositoryModule());
                modules.Add(new NHibernateSessionModule(connection));
            }
                
            return modules;
        }
    }
}
