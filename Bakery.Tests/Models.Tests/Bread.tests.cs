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
    public void GetBread_HoldsIntFromUser_True()
    {
      Bread newOrder = new Bread(3);
      Assert.AreEqual(true, newOrder.GetBread(3));
    }

    [TestMethod]
    public void BreadValue_AssignCostToBread_Int()
    {
      Bread newOrder = new Bread(3);
      Dictionary<string, int> value = new Dictionary<string, int> 
      {
        {"Bread", 5}
      };
      CollectionAssert.AreEqual(value, newOrder.BreadValue());
    }
  }
}