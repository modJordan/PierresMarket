using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMarket.Models;
using System;

namespace PierresMarket.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void NewOrder_CreatesInstance_OrderInstance()
    {
      //Arrange & Act
      Order newOrder = new Order("Croissant Order", "Weekly supply of croissants.", 50.00, DateTime.Now);
      Assert.AreEqual(typeof(Order), newOrder.GetType());

      //Assert
      Assert.IsInstanceOfType(newOrder, typeof(Order));
    }
  }
}