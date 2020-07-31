using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    
    public Bread(int order)
    {
      Order = order;
    }

    public int BreadValue()
    {
      int newOrder = Order * 5;
      for (int i = 0; i < Order; i++)
      {
        if (i % 3 == 0) 
        {
          newOrder -= 5;
        }
      }
      return newOrder;
    }
  }
}