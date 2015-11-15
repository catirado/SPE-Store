using NHibernate;
using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate
{
    public class NHibernateRepository<T> : NHibernateBase, IRepository<T> where T : DomainObject
    {
        public NHibernateRepository(ISession session) : base(session) { }

        public T GetById(int id)
        {
            return Transact(() => Session.Get<T>(id));
        }

        public T Add(T entity)
        {
            Transact(() => Session.Save(entity));
            return entity;
        }

        public T Update(T entity)
        {
            Transact(() => Session.Merge(entity));
            return entity;
        }

        public void Delete(T entity)
        {
            Transact(() => Session.Delete(entity));
        }
    }
}
