﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPE.Store.Web.Models
{
    public class CategoriesListViewModel : BaseViewModel
    {
        public IList<CategoryListViewModel> Categories { get; set; }
    }
}