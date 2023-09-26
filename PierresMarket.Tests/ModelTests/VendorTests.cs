using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMarket.Models;
using System;

namespace PierresMarket.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void NewVendor_CreatesInstance_VendorInstance()
    {

      // Arrange & Act
      Vendor newVendor = new Vendor("test vendor", "test description");

      //Assert
      Assert.IsInstanceOfType(newVendor, typeof(Vendor));
    }

    [TestMethod]
    public void FindVendor_ReturnInstance_VendorInstance()
    {

      //Arrange
      Vendor newVendor1 = new Vendor("test vendor", "test description");

      //Act
      Vendor result = Vendor.Find(newVendor1.Id);
      //Assert
      Assert.AreEqual(newVendor1, result);

    }
  }
}






//Get all
//Find