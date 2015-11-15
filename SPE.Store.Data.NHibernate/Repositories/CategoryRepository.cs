using NHibernate;
using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate.Repositories
{
    public class CategoryRepository : NHibernateBase, ICategoryRepository
    {
        public CategoryRepository(ISession session)
            : base(session)
        {
        }

        public IList<Category> GetAll()
        {
            return Transact(() => base.Session.QueryOver<Category>()).List();
        }
    }
}
