using SPE.Store.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NPoco.Adapters
{
    public static class PageAdapterFactory<T>
    {
        public static IPage<T> CreateAdapter(global::NPoco.Page<T> page)
        {
            return new Infrastructure.Domain.Page<T>
            {
                CurrentPage = page.CurrentPage,
                ItemsPerPage = page.ItemsPerPage,
                TotalItems = page.TotalItems,
                TotalPages = page.TotalPages,
                Items = page.Items.ToList()
            };
        }
    }
}
