using System;
using Microsoft.AspNetCore.Mvc;

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

    public Order(string title, string description, double price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = ++_currentId;
    }

    public static Order GetAll()
    {
      Order allOrders = new Order("title", "description", 0.00, new DateTime(2020, 1, 1));
      return allOrders;
    }


  }
}