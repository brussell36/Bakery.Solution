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

    public bool GetBread()
    {
      return true;
    }

    public Dictionary<string, int> BreadValue()
    {
      Dictionary<string, int> breadOrder = new Dictionary<string, int> 
      {
        {"Bread", 5}
      };
      return breadOrder;
    }

    // public int BreadValue(Dictionary<string, int> breadOrder)
    // {
    //   return 15;
    // }
  }
}