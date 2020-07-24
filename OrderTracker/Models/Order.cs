using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string TypeOfBread { get; set; }
    public int Quantity { get; set; }
    public int Date { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order(string typeOfBread, int quantity, int date, int price)
    {
      TypeOfBread = typeOfBread;
      Quantity = quantity;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAllOrders()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId];
    }

  }  
}  