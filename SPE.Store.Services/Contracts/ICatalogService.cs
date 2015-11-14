using SPE.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPE.Store.Services.Contracts
{
    public interface ICatalogService
    {
        IList<Product> GetMostPurchased();
    }
}
