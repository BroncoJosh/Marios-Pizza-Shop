using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariosPizzaShop.Models;

namespace MariosPizzaShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pizza> PizzasOfTheWeek { get; set; }
    }
}
