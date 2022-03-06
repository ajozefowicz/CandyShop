using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CateogryId=1, CategoryName="Hard Candy", CategoryDescription="Super hard candy"},
            new Category{CateogryId=2, CategoryName="Chocolate Candy", CategoryDescription="very chocolate candy"},
            new Category{CateogryId=3, CategoryName="Fruit Candy", CategoryDescription="Sour fruit candy"},
        };
    }
}
