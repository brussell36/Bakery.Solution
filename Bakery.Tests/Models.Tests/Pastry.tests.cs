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
    public void PastryValue_ReturnCostOfPastry_Int()
    {
      Pastry newOrder = new Pastry(3);
      Assert.AreEqual(5, newOrder.PastryValue());
    }
  }
}