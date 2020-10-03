using System.Collections.Generic;

namespace LearningBlazorWeb.Shared
{
    public class Basket
    {
        public Customer Customer { get; set; }
        public List<int> ListOrders { get; set; } = new List<int>();

        public bool HasPaid { get; set; }
        
        public void Add(int pizzaId)
        {
            ListOrders.Add(pizzaId);
        }

        public void RemoveAt(int position)
        {
            ListOrders.RemoveAt(position);
        }
    }
}