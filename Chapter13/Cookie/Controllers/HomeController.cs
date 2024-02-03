using Microsoft.AspNetCore.Mvc;


namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            return View();
        }
        public string list(string id)
        {
            return "return list";
        }
    }
}