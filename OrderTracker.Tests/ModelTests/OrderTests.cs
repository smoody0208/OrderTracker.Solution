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
      Assert.AreEqual(typeOfBread, result);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsOrders_OrderList()
    {
      string typeOfBread = "Banana Bread";
      int quantity = 10;
      int date = 10/10/10;
      int price = 1000;
      string typeOfBread1 = "Not a banana bread";
      int quantity1 = 20;
      int date1 = 11/11/11;
      int price1 = 1111;
      Order newOrder = new Order(typeOfBread, quantity, date, price);
      Order newOrder2 = new Order(typeOfBread1, quantity1, date1, price1);
      List<Order> newOrderList = new List<Order> { newOrder, newOrder2 };

      List<Order> result = Order.GetAllOrders();

      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string typeOfBread = "Banana Bread";
      int quantity = 10;
      int date = 10/10/10;
      int price = 1000;
      Order newOrder = new Order(typeOfBread, quantity, date, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string typeOfBread = "Banana Bread";
      int quantity = 10;
      int date = 10/10/10;
      int price = 1000;
      string typeOfBread1 = "Not a banana bread";
      int quantity1 = 20;
      int date1 = 11/11/11;
      int price1 = 1111;
      Order newOrder = new Order(typeOfBread, quantity, date, price);
      Order newOrder2 = new Order(typeOfBread1, quantity1, date1, price1);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}    
