using System.Collections.Generic;


namespace PierresMarket
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    public List<Order> Orders { get; set; }


    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();

    }



  }
}