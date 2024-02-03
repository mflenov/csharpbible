using Microsoft.AspNetCore.Mvc;


namespace MyWebSite
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            return Content("ID Value = " + id);
        }

        public ActionResult list(string id)
        {
            return Content("return list");
        }

        public IActionResult loadarticle(int id)
        {
            if (id == 10)
            {
                return Content("Good stuff");
            }
            return this.NotFound();
        }

        public Person person()
        {
            return new Person
            {
                FirstName = "Михаил",
                LastName = "Фленов"
            };
        }
    }
}