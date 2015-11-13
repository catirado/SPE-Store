using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Infrastructure.Domain
{
    public interface IPage<T>
    {
        long CurrentPage { get; set; }
        long TotalPages { get; set; }
        long TotalItems { get; set; }
        long ItemsPerPage { get; set; }
        List<T> Items { get; set; }
    }
}
