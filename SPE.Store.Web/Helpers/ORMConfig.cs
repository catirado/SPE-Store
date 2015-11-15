using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SPE.Store.Web.Helpers
{
    public static class ORMConfig
    {
        public static string ORM
        {
            get
            {
                return ConfigurationManager.AppSettings["ORM"];
            }
        }

        public static string Connection
        {
            get
            {
                return ConfigurationManager.AppSettings["ORM:Connection"];
            }
        }
    }
}