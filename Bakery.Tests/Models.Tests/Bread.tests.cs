using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class TestBread
  {
    [TestMethod]
    public void GetBread_BreadIsObject_True()
    {
      Bread newOrder = new Bread(2);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

    [TestMethod]
    public void BreadValue_ReturnCostOfBread_Int()
    {
      Bread newOrder = new Bread(3);
      Assert.AreEqual(10, newOrder.BreadValue());
    }
  }
}