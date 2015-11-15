using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;
using SPE.Store.Infrastructure.Domain;

namespace SPE.Store.Data.NPoco
{
    public class NPocoRepository<T> : IRepository<T> where T : DomainObject
    {
        public T GetById(int id)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                return db.SingleById<T>(id);
            }
        }

        public T Add(T entity)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                db.Insert(entity);
                return entity;
            }
        }

        public T Update(T entity)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                db.Update(entity);
                return entity;
            }
        }

        public void Delete(T entity)
        {
            using (var db = NPocoDataBaseFactory.DbFactory.GetDatabase())
            {
                db.Delete(entity);
            }
        }

    }
}
