using OrderTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Some Vendor Test", "Some Address Test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string vendorAddress = "P. Sherman, 42 Wallaby Way, Sydney";
      string vendorName = "Finding Nemo";
      string vendorAddress2 = "123 Why Worry Lane";
      string vendorName2 = "It's All Good Bakery";
      Vendor newVendor2 = new Vendor (vendorName, vendorAddress);
      Vendor newVendor = new Vendor (vendorName2, vendorAddress2);

      string result = newVendor.VendorName;

      Assert.AreEqual(vendorName2, result);
    }

    [TestMethod]
    public void GetAddress_ReturnsAddress_String()
    {
      string vendorAddress = "P. Sherman, 42 Wallaby Way, Sydney";
      string vendorName = "Finding Nemo";
      string vendorAddress2 = "123 Why Worry Lane";
      string vendorName2 = "It's All Good Bakery";
      Vendor newVendor2 = new Vendor (vendorName, vendorAddress);
      Vendor newVendor = new Vendor (vendorName2, vendorAddress2);

      string result = newVendor.VendorAddress;

      Assert.AreEqual(vendorAddress2, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_int()
    {
      string vendorAddress = "P. Sherman, 42 Wallaby Way, Sydney";
      string vendorName = "Finding Nemo";
      string vendorAddress2 = "123 Why Worry Lane";
      string vendorName2 = "It's All Good Bakery";
      Vendor newVendor = new Vendor (vendorName, vendorAddress);
      Vendor newVendor2 = new Vendor (vendorName2, vendorAddress2);

      int result = newVendor2.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorAddress = "P. Sherman, 42 Wallaby Way, Sydney";
      string vendorName = "Finding Nemo";
      string vendorAddress2 = "123 Why Worry Lane";
      string vendorName2 = "It's All Good Bakery";
      Vendor newVendor = new Vendor (vendorName, vendorAddress);
      Vendor newVendor2 = new Vendor (vendorName2, vendorAddress2);
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };

      List<Vendor> result = Vendor.GetAllVendors();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorAddress = "P. Sherman, 42 Wallaby Way, Sydney";
      string vendorName = "Finding Nemo";
      string vendorAddress2 = "123 Why Worry Lane";
      string vendorName2 = "It's All Good Bakery";
      Vendor newVendor = new Vendor (vendorName, vendorAddress);
      Vendor newVendor2 = new Vendor (vendorName2, vendorAddress2);

      Vendor result = Vendor.Find(1);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string typeOfBread = "Roll";
      int quantity = 10;
      int date = 7/30/20;
      int price = 5;
      Order newOrder = new Order(typeOfBread, quantity, date, price);
      List<Order> newOrderList = new List<Order> { newOrder };
      string vendorAddress = "P. Sherman, 42 Wallaby Way, Sydney";
      string vendorName = "Finding Nemo";
      Vendor newVendor = new Vendor (vendorName, vendorAddress);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}