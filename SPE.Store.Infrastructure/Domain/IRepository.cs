using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Domain
{
    public interface IRepository<T> where T : DomainObject
    {
        T GetById(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
    }
}
