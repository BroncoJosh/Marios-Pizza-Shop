using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariosPizzaShop.Models;
using MariosPizzaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MariosPizzaShop.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository pizzaRepository, ICategoryRepository categoryRepository)
        {
            _pizzaRepository = pizzaRepository;
            _categoryRepository = categoryRepository;
        }

        /*public ViewResult List()
        {
            PizzasListViewModel pizzasListViewModel = new PizzasListViewModel();
            pizzasListViewModel.Pizzas = _pizzaRepository.Pizzas;
            pizzasListViewModel.CurrentCategory = "Cheese Pizza";
            return View(pizzasListViewModel);
        }
*/

        public ViewResult List(string category)
        {
            IEnumerable<Pizza> pizzas = new List<Pizza>();
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pizzas = _pizzaRepository.Pizzas.OrderBy(p => p.PizzaId);
                currentCategory = "All Pizzas";
            }
            else
            {
                pizzas = _pizzaRepository.Pizzas.Where(p => p.Category.CategoryName.Equals(category)).OrderBy(p => p.PizzaId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            return View(new PizzasListViewModel
            {
                Pizzas = pizzas,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var pizza = _pizzaRepository.GetPizzaId(id);
            if (pizza == null)
                return NotFound();

            return View(pizza);
        }
    }
}
