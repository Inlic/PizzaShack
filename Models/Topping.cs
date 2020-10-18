namespace PizzaShack.Models
{
  public class Topping
  {
    public string Name { get; set; }
    public decimal Price { get; set; } // whenever we're looking at real world pricing we use this
    public Topping(string name, decimal price)
    {
      Name = name;
      Price = price;
    }

  }
}