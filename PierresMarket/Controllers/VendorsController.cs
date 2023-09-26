using PierresMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace PierresMarket.Controllers
{

  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      VendorViewModel viewModel = new VendorViewModel
      {
        Vendors = Vendor.GetAll(),
        CurrentVendor = null
      };
      return View(viewModel);
    }

    [HttpGet("/vendors/create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/vendors/create")]
    public ActionResult Create(string name, string description)
    {
      Vendor myVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }


    [HttpGet("vendor/{Id}")]
    public ActionResult Details(int Id)
    {
      Vendor vendor = Vendor.Find(Id);
      if (vendor == null)
      {
        return RedirectToAction("Index");
      }
      VendorViewModel viewModel = new VendorViewModel
      {
        Vendors = Vendor.GetAll(),
        CurrentVendor = vendor
      };

      // Order allOrders = new Order("title", "description", 0.00, new DateTime(2020, 1, 1));
      // viewModel.CurrentVendor.Orders.Add(allOrders);
      return View(viewModel);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult CreateOrder(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }


    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult CreateOrder(int vendorId, string orderTitle, string orderDescription, double orderPrice, DateTime orderDate)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      if (selectedVendor == null)
      {
        return RedirectToAction("Index");
      }
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      selectedVendor.Orders.Add(newOrder);
      return RedirectToAction("Details", new { id = vendorId });
    }

    [HttpGet("/vendors/allorders")]
    public ActionResult AllOrders()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }
}