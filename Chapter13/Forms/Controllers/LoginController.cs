using Microsoft.AspNetCore.Mvc;
using MyWebSite.ViewModel;

namespace MyWebSite.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "GET запрос";
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            ViewBag.Title = "POST запрос";
            return View(model);
        }
    }
}
