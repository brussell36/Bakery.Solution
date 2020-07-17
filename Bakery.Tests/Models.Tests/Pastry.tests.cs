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
  }
}