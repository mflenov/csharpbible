using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using TestApi.BL;
using TestApi.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        SessionStorage storage = new SessionStorage();

        [HttpGet]
        public string Get(string sessionid, string name)
        {
            var session = storage.GetSession(sessionid);
            if (session == null)
                throw new Exception("Неверная сессия");
            return session.Values[name]?.ToString() ?? "";
        }

        [HttpPut]
        public void Put(DataRequest request)
        {
            var session = storage.GetSession(request.SessionId);
            if (session == null)
                throw new Exception("Неверная сессия");
            session.Values.Add(request.Name, request.Value);
        }

        [HttpPatch]
        public void Patch(DataRequest request)
        {
            var session = storage.GetSession(request.SessionId);
            if (session == null)
                throw new Exception("Неверная сессия");
            session.Values[request.Name] = request.Value;
        }

        [HttpDelete]
        public void Delete(string sessionid, string name)
        {
            var session = storage.GetSession(sessionid);
            if (session == null)
                throw new Exception("Неверная сессия");
            session.Values.Remove(name);
        }
    }
}

