using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariosPizzaShop.Models;
using MariosPizzaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MariosPizzaShop.Controllers.Api
{

    [Route("api/[controller]")]
    public class PizzaDataController : Controller
    {

        private readonly IPizzaRepository _pizzaRepository;

        public PizzaDataController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        [HttpGet]
        public IEnumerable<PizzaViewModel> LoadMorePizzas()
        {
            IEnumerable<Pizza> dbPizzas = null;

            dbPizzas = _pizzaRepository.Pizzas.OrderBy(p => p.PizzaId).Take(10);

            List <PizzaViewModel> pizzas = new List<PizzaViewModel>();

            foreach (var dbPizza in dbPizzas)
            {
                pizzas.Add(mapDbPizzaToPizzaViewModel(dbPizza));
            }

            return pizzas;
        }

        private PizzaViewModel mapDbPizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel()
            {
                PizzaId = pizza.PizzaId,
                Name = pizza.Name,
                Price = pizza.Price,
                ShortDescription = pizza.ShortDescription,
                ImageThumbnailUrl = pizza.ImageThumbnailUrl
            };
        }
    }
}