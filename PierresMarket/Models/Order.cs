using System;

namespace PierresMarket
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public double Price { get; }
    public DateTime Date { get; }

    public Order(string title, string description, double price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}