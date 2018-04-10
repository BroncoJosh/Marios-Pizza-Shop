using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariosPizzaShop.Models;
using MariosPizzaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MariosPizzaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;

        public HomeController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PizzasOfTheWeek = _pizzaRepository.PizzasOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}