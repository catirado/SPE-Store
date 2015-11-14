using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPE.Store.Web.Controllers
{
    public class ProductsController : BaseController
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
