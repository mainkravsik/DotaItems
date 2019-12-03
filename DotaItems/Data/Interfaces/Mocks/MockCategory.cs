using System;
using System.Collections.Generic;
using System.Linq;
using DotaItems.Data.Interfaces;
using System.Threading.Tasks;
using DotaItems.Data.Models;

namespace DotaItems.Data.Interfaces.Mocks
{
    public class MockCategory : IItemsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Тир 1", desc = "Предметы, падающие после 5 минуты"},
                    new Category {categoryName = "Тир 2", desc = "Предметы, падающие после 15 минуты"}
                };
            }
        }
    }
    {
        
    }
}
