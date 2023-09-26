using System;
using System.Collections.Generic;



namespace PierresMarket.Models
{
  public class Vendor
  {
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public List<Order> Orders { get; set; }

    private static List<Vendor> _instances = new List<Vendor>();

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      _instances.Add(this);
      Id = _instances.Count;

    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int id)
    {
      if (id < 1 || id > _instances.Count)
      {
        return null;
      }
      return _instances[id - 1];
    }
  }
}