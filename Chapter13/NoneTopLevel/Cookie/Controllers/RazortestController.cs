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

        public IActionResult List()
        {
            var people = new Person[] {
                  new Person() { FirstName = "Mikhail", LastName = "Flenov", Age = 42 },
                  new Person() { FirstName = "Ivan", LastName = "Sergeev", Age = 29 },
                  new Person() { FirstName = "Lena", LastName = "Petrova", Age = 20 },
              };
            return View(people);
        }
    }
}
