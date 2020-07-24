  using System.Collections.Generic;

  namespace OrderTracker.Models
{
  public class Vendor
  {
    
    private static List<Vendor> _instances = new List<Vendor>{};
    public string VendorName { get; set; }
    public string VendorAddress { get; set; }
    public int Id { get; }
  


    public Vendor(string vendorName, string vendorAddress) 
    {
      VendorName = vendorName;
      VendorAddress = vendorAddress;
      Id = _instances.Count;
    }
  }  
}