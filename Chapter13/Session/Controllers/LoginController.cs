using Microsoft.AspNetCore.Mvc;
using MyWebSite.ViewModel;
using System;

using Microsoft.AspNetCore.Http;

namespace MyWebSite.Controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {

        }

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
                HttpContext.Session.SetString("username", model.Email);
                return Redirect("/");
            }
            ViewBag.Title = "POST запрос";
            return View(model);
        }
    }
}
