using Microsoft.AspNetCore.Mvc;

namespace PierresMarket.Controllers
{

  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}