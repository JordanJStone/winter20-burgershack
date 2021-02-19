using System.ComponentModel.DataAnnotations;

namespace winter20_burgershack.Models
{
  public class Drink
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public double Price { get; set; }

    public Drink()
    {

    }

    public Drink(string name, double price)
    {
      Name = name;
      Price = price;
    }

  }
}