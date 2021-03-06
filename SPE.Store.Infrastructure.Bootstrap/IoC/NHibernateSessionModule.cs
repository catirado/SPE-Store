﻿using NHibernate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Web.Common;

namespace SPE.Store.Infrastructure.Bootstrap.IoC
{
    public class NHibernateSessionModule : NinjectModule
    {
        private string _connection;

        public NHibernateSessionModule(string connection)
        {
            _connection = connection;
        }

        public override void Load()
        {
            Bind<ISessionFactory>().ToProvider<NhibernateSessionFactoryProvider>().InSingletonScope();
            Bind<NhibernateSessionFactoryProvider>().ToSelf().WithConstructorArgument("connection", _connection);
            Bind<ISession>().ToMethod(context => context.Kernel.Get<ISessionFactory>().OpenSession()).InRequestScope();
        }
    }
}
