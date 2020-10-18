using System.Collections.Generic;
using System.Linq;

namespace PizzaShack.Models
{
  public enum PizzaSizes
  {
    Personal = 1,  // starts at 0 unless given a value
    Medium,
    Large,
    Family
  }
  public class Pizza
  {
    private decimal _BasePrice = 6;

    public string Name { get; set; }
    public List<Topping> Toppings { get; set; }
    public PizzaSizes Size { get; set; }

    public decimal Price
    {
      get
      {
        return _BasePrice + (decimal)Size + Toppings.Sum(topping => topping.Price);
      }
    }
  }
}