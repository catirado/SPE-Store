using Ninject.Modules;
using SPE.Store.Services;
using SPE.Store.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Bootstrap.IoC
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICatalogService>().To<CatalogService>();
            Bind<IShoppingCartService>().To<ShoppingCartService>();
        }
    }
}
