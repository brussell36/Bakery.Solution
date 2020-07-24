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

    public bool GetPastry()
    {   
      if (Order.GetType() == typeof(int))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public Dictionary<string, int> PastryCost()
    {
      Dictionary<string, int> pastryOrder = new Dictionary<string, int> 
      {
        {"Pastry", 2}
      };
      return pastryOrder;
    }

    public int PastryValue()
    {
      int newOrder = Order * 2;
      for (int i = 0; i < Order; i++)
      {
        if (i % 2 == 0)
        {
          newOrder -= 1;
        }
      }
      return newOrder;
    }
  }
}