using System;
using System.Collections.Generic;

namespace PierresMarket.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public double Price { get; }
    public DateTime Date { get; }
    public int Id { get; }
    private static int _currentId = 0;
    private static List<Order> _instances = new List<Order>();

    public Order(string title, string description, double price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = ++_currentId;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
      _currentId = 0;
    }
  }
}