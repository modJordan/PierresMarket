using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresMarket;
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
    // }
  }
}

