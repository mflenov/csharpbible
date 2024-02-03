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

                Response.Cookies.Append("usercookie", model.Email,
                     new CookieOptions()
                     {
                         Path = "/",
                         Expires = DateTimeOffset.Now.AddDays(10)
                     }
                 );
                return Redirect("/");
            }
            ViewBag.Title = "POST запрос";
            return View(model);
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("usercookie");
            return Redirect("/");
        }
    }
}
