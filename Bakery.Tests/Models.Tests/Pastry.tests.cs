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
  }
}