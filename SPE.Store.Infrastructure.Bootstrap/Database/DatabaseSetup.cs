﻿using SPE.Store.Data.NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Bootstrap.Database
{
    public static class DatabaseSetup
    {
        public static void Setup()
        {
            NPocoDataBaseFactory.Setup();
        }
    }
}
