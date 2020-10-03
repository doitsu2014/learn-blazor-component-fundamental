using System.Collections.Generic;
using System.Linq;

namespace LearningBlazorWeb.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public Pizza GetPizzaById(int id)
        {
            return Pizzas.SingleOrDefault(predicate: p => p.Id == id);
        }
    }
}