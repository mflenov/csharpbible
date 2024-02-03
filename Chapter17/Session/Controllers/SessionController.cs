using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using TestApi.Model;
using TestApi.BL;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessionController : ControllerBase
    {
        SessionStorage storage = new SessionStorage();

        [HttpGet]
        public MemberSession Get(string? id)
        {
            var session = storage.GetSession(id);
            if (session == null)
                session = storage.CreateSession();
            return session!;
        }
    }
}