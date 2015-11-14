using Ninject.Modules;
using SPE.Store.Data.NHibernate.Repositories;
using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Bootstrap.IoC
{
    public class NHibernateRepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<IShoppingCartRepository>().To<ShoppingCartRepository>();
        }
    }
}
