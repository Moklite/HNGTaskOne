using HNGTaskOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNGTaskOne.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public List<User> Get()
        {
            List<User> users = new List<User>();
            users.Add(new User("Pamilerin", true, 25, "Pamilerin is a .NET developer and his goal is to be the best at what he does"));

            return users;

        }
    }
}
