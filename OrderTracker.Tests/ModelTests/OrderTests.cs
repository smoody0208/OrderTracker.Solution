using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace VendorsPage.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Banana Bread", 10, 10/10/10, 1000);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
  }
}    
