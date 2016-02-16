using Microsoft.AspNet.Mvc;

namespace AnnetKatan.CreativeCraziness.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Error()
    {
      return View();
    }
  }
}