using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
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

    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      string typeOfBread = "Banana Bread";
      string typeOfBread1 = "Not a banana bread";
      int quantity = 10;
      int date = 10/10/10;
      int price = 1000;
      Order newOrder = new Order(typeOfBread, quantity, date, price);
      string result = newOrder.TypeOfBread;
      Assert.AreEqual(typeOfBread1, result);
    }
    
  }
}    
