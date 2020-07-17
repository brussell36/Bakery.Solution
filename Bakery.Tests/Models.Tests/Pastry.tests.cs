using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class TestPastry
  {
    [TestMethod]
    public void GetPastry_PastryIsObject_True()
    {
      Pastry newOrder = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }

    [TestMethod]
    public void GetPastry_PastryHoldsValue_True()
    {
      Pastry newOrder = new Pastry(3);
      Assert.AreEqual(true, newOrder.GetPastry());
    }

    [TestMethod]
    public void PastryCost_AssignCostToPastry_Int()
    {
      Pastry newOrder = new Pastry(3);
      Dictionary<string, int> value = new Dictionary<string, int> 
      {
        {"Pastry", 2}
      };
      CollectionAssert.AreEqual(value, newOrder.PastryCost());
    }

    [TestMethod]
    public void PastryValue_ReturnCostOfPastry_Int()
    {
      Pastry newOrder = new Pastry(3);
      Assert.AreEqual(6, newOrder.PastryValue());
    }
  }
}