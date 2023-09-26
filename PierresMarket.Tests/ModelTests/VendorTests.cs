using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMarket.Models;
using System.Collections.Generic;
using System;

namespace PierresMarket.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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

    [TestMethod]
    public void GetAllVendor_ReturnInstance_VendorInstance()
    {

      //Arrange
      Vendor newVendor1 = new Vendor("test vendor1", "test description1");
      Vendor newVendor2 = new Vendor("test vendor2", "test description2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}






//Get all
//Find