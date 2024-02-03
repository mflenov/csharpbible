using Microsoft.AspNetCore.Mvc;

namespace MyWebSite
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return "ID Value = " + id;
        }
        public string list(string id)
        {
            return "return list";
        }
    }
}
