using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MariosPizzaShop.Models
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _appDbContext;

        public PizzaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pizza> Pizzas
        {
            get { return _appDbContext.Pizzas.Include(c => c.Category); }
        }

        public IEnumerable<Pizza> PizzasOfTheWeek
        {
            get { return _appDbContext.Pizzas.Include(c => c.Category).Where(p => p.IsPizzaOfTheWeek); }
        }

        public Pizza GetPizzaId(int pizzaId)
        {
            return _appDbContext.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);
        }

    }
}
