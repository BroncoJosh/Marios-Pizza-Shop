using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariosPizzaShop.Models;
using MariosPizzaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MariosPizzaShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPizzaRepository pizzaRepository, ShoppingCart shoppingCart)
        {
            _pizzaRepository = pizzaRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        /*public RedirectToActionResult AddToShoppingCart(int pizzaId)
        {
            var selectedPizza = _pizzaRepository.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);

        }*/

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var selectedPizza = _pizzaRepository.Pizzas.FirstOrDefault(p => p.PizzaId == id);
            Console.WriteLine("Id: " + id);
            if (selectedPizza != null)
            {
                _shoppingCart.AddToCart(selectedPizza, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selectedPizza = _pizzaRepository.Pizzas.FirstOrDefault(p => p.PizzaId == id);

            if (selectedPizza != null)
            {
                _shoppingCart.RemoveFromCart(selectedPizza);
            }
            return RedirectToAction("Index");
        }
    }
}