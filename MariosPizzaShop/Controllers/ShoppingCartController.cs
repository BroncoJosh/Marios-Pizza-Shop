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
    }
}