namespace Bakery.Models
{
  public class Bread
  {
    public int Order { get; set; }

    public Bread(int order)
    {
      Order = order;
    }

    public int GetBread(int order)
    {
      return order;
    }
  }
}