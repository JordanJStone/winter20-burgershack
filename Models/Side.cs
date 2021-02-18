namespace winter20_burgershack.Models
{
  public class Side
  {

    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Side()
    {

    }

    public Side(string name, double price)
    {
      Name = name;
      Price = price;
    }
  }
}