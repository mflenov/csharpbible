using Microsoft.AspNetCore.Mvc;
using MyWebSite.Model.Interfaces;

namespace MyWebSite.Controllers
{
    public class DbTestController : Controller
    {
        IDbConnection db;
        public DbTestController(IDbConnection db)
        {
            this.db = db;
        }

        public string Index()
        {
            using (var connection = db.CreateConnection())
            {
                connection.Open();
                return connection.State.ToString();
            }
        }
    }
}
