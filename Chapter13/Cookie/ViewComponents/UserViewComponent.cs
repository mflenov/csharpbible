using Microsoft.AspNetCore.Mvc;
using MyWebSite.ViewModel;

using Microsoft.AspNetCore.Http;

namespace MyWebSite.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string username = HttpContext.Session.GetString("username");
            if (username == null)
            {
                if (HttpContext.Request.Cookies.ContainsKey("usercookie"))
                {
                    username = HttpContext.Request.Cookies["usercookie"];
                }
            }
            var model = new UserModel()
            {
                IsLoggedIn = username != null,
                UserName = username
            };
            return View("User", model);
        }
    }
}
