using Microsoft.AspNetCore.Mvc;
using MyWebSite.ViewModel;

namespace MyWebSite
{
    public class RazortestController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person()
            {
                FirstName = "Mikhail",
                LastName = "Flenov",
                Age = 42
            };

            return View(person);
        }
    }
}
