using OrderTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTest
  {
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
  }
}