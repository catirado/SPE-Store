using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SPE.Store.Data.EF
{
    public class EFRepository<T> : IRepository<T> where T : DomainObject
    {
        private readonly DbSet<T> dbSet;

        public T GetById(int id)
        {
            return dbSet.SingleOrDefault(x => x.Id == id);
        }

        public T Add(T entity)
        {
            return dbSet.Add(entity);
        }

        public T Update(T entity)
        {
            dbSet.Attach(entity);
            return entity;
            //dbSet.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
