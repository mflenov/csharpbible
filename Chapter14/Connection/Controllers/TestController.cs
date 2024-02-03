using Microsoft.AspNetCore.Mvc;

namespace MyWebSite
{
    [Route("my/test")]
    public class TestController : Controller
    {
        [Route("show")]
        public string Index()
        {
            return "Index Test method";
        }

        [Route("details/{id}")]
        public string Details(string id)
        {
            return "ID Value = " + id;
        }
    }
}
