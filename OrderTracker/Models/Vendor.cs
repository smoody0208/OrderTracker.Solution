  using System.Collections.Generic;
  using OrderTracker.Models;

  namespace OrderTracker.Models
{
  public class Vendor
  {
    
    private static List<Vendor> _instances = new List<Vendor>{};
    public string VendorName { get; set; }
    public string VendorAddress { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
  
    public Vendor(string vendorName, string vendorAddress) 
    {
      VendorName = vendorName;
      VendorAddress = vendorAddress;
      Id = _instances.Count;
      _instances.Add(this);
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAllVendors()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  } 
}