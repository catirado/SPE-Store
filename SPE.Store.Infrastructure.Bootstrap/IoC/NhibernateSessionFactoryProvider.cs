using NHibernate;
using Ninject.Activation;
using SPE.Store.Data.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Bootstrap.IoC
{
    public class NhibernateSessionFactoryProvider : Provider<ISessionFactory>
    {
        protected override ISessionFactory CreateInstance(IContext context)
        {
            var sessionFactory = new NHibernateSessionFactory();
            return sessionFactory.GetSessionFactory();
        }
    }
}
