using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAllVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorAddress)
    {
      Vendor newVendor = new Vendor(vendorName, vendorAddress);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> selectedOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("order", selectedOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string typeOfBread, int quantity, int date, int price)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(typeOfBread, quantity, date, price);
      foundVendor.AddOrder(newOrder); 
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("order", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
    
  }
}    