using System.Collections.Generic;
using System.Linq;

namespace PizzaShack.Models
{
  public class Order
  {
    public List<Pizza> Pizzas { get; set; }

    public decimal TotalPrice
    {
      get
      {
        return Pizzas.Sum(pizza => pizza.Price);
      }
    }
  }
}