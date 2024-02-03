using Microsoft.AspNetCore.Mvc;


namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Id(string id)
        {
            return "ID Value = " + id;
        }
        public string list(string id)
        {
            return "return list";
        }
    }
}