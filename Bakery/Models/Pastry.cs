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
      return false;
    }
  }
}