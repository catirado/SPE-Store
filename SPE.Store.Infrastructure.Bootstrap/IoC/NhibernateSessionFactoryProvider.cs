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
        private string _connection;

        public NhibernateSessionFactoryProvider(string connection)
        {
            _connection = connection;
        }

        protected override ISessionFactory CreateInstance(IContext context)
        {
            var sessionFactory = new NHibernateSessionFactory();
            return sessionFactory.GetSessionFactory(_connection);
        }
    }
}
