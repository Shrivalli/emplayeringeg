using System.Data.Common;
using firstapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly FisbankDbContext _db;

        public LoginController(FisbankDbContext db)
        {
            _db=db;
        }
        [HttpPost]
        public async Task<ActionResult<Usertbl>> Login(Usertbl t)
        {
                var user=(from i in _db.Usertbls
                where i.Username==t.Username && i.Password==t.Password
                select i).SingleOrDefault();
                if(user!=null)
                return user;
                else
                return NotFound();
        }

    }
    }