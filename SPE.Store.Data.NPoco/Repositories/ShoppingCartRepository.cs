﻿using SPE.Store.Domain;
using SPE.Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Repositories
{
    public class ShoppingCartRepository : NPocoRepository<Cart>, IShoppingCartRepository
    {

    }
}
