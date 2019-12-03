using DotaItems.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaItems.Data.Interfaces
{
    interface IAllItems
    {
        IEnumerable<Items> Items { get;}
        IEnumerable<Items> GetFavItems { get; set; }
        Items getObjectItems(int itemsID);
    }
}
