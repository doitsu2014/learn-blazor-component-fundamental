using System.Linq;
using Newtonsoft.Json;

namespace LearningBlazorWeb.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public Basket Basket { get; set; } = new Basket();
        public UI UI { get; set; } = new UI();

        public decimal TotalPrice => this.Basket.Orders.Sum(id => Menu.GetPizzaById(id).Price); 
        public string ToJson() => JsonConvert.SerializeObject(this);
    }
}