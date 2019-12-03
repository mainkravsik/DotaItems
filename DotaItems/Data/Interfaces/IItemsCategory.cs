using DotaItems.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaItems.Data.Interfaces
{
    interface IItemsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
