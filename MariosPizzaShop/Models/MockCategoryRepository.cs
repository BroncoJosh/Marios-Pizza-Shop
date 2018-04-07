using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MariosPizzaShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {

                    new Category{ CategoryId=1, CategoryName = "Meat Pizza", Description = "All Meat Pizzas"},
                    new Category{ CategoryId=2, CategoryName = "Cheese Pizza", Description = "All Cheese Pizzas"},
                    new Category{ CategoryId=3, CategoryName = "Seasonal Pizza", Description = "Yummy Seasonal Pizzas"}
                };
            }
        }
    }
}
