using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresMarket.Models;
using System;

namespace PierresMarket.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }

}