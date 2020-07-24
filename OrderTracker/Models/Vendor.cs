  namespace OrderTracker.Models
{
  public class Vendor
  {
  
    public string VendorName { get; set; }
    public string VendorAddress { get; set; }
  


    public Vendor(string vendorName, string vendorAddress) 
    {
      VendorName = vendorName;
      VendorAddress = vendorAddress;
    }
  }  
}