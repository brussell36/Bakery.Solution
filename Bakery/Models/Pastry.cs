using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Order { get; set; }

    public Pastry(int order)
    {
      Order = order;
    }

    public int PastryValue()
    {
      int newOrder = Order * 2;
      for (int i = 0; i < Order; i++)
      {
        if (i % 3 == 0)
        {
          newOrder -= 1;
        }
      }
      return newOrder;
    }
  }
}