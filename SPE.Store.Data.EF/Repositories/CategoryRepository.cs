﻿using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.EF.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IList<Domain.Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
