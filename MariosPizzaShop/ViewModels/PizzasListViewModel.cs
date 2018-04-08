using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariosPizzaShop.Models;

namespace MariosPizzaShop.ViewModels
{
    public class PizzasListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }

        public string CurrentCategory { get; set; }
    }
}
