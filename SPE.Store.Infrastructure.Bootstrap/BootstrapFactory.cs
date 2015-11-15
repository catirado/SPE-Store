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
        public static void DatabaseSetup(string orm, string connection)
        {
            NPocoDatabaseSetup.Setup();
        }

        public static IList<NinjectModule> GetModules(string orm)
        {
            var modules = new List<NinjectModule>();
            modules.Add(new ServicesModule());
            if (orm == "NPoco")
                modules.Add(new NPocoRepositoriesModule());
            return modules;
        }
    }
}
