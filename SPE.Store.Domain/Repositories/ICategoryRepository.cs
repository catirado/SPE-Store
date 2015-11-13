using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Domain.Repositories
{
    public interface ICategoryRepository
    {
        IList<Category> GetCategories();
    }
}
