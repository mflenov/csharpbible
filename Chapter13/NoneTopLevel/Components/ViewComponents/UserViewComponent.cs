using Microsoft.AspNetCore.Mvc;
using MyWebSite.ViewModel;

namespace MyWebSite.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new UserModel()
            {
                IsLoggedIn = true,
                UserName = "mflenov"
            };
            return View("User", model);
        }
    }
}
