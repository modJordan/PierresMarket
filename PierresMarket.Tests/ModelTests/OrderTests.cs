using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresMarket.Models;


namespace PierresMarket.Tests
{
  [TestClass]
  public class OrderTests
  {

  [TestInitialize]
        public void SetUp()
        {
            Order.ClearAll();
        }
        
    [TestMethod]
    public void NewOrder_CreatesInstance_OrderInstance()
    {
      //Arrange & Act
      Order newOrder = new Order("Croissant Order", "Weekly supply of croissants.", 50.00, DateTime.Now);
      Assert.AreEqual(typeof(Order), newOrder.GetType());

      //Assert
      Assert.IsInstanceOfType(newOrder, typeof(Order));
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderInstances_OrderList()
    {
      // Arrange
      string title1 = "Order1";
      string description1 = "Description1";
      Order newOrder1 = new Order(title1, description1, 10.0, DateTime.Now);

      string title2 = "Order2";
      string description2 = "Description2";
      Order newOrder2 = new Order(title2, description2, 20.0, DateTime.Now.AddDays(1));

      List<Order> expectedList = new List<Order> { newOrder1, newOrder2 };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(expectedList, result);
    }
  }
}