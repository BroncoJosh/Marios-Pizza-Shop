using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MariosPizzaShop.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> Pizzas { get; }

        IEnumerable<Pizza> PizzasOfTheWeek { get; }

        Pizza GetPizzaId(int pizzaId);
    }
}
