using Microsoft.AspNetCore.Mvc;

namespace MyWebSite
{
    public class RazortestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
