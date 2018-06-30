using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
using Veritas.Models;

namespace Veritas.Controllers
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //[Route("Login")]
        [HttpPost]
        [ActionName("Login")]
        public async Task<IHttpActionResult> Login(string email, string password)
        {
            //
            var user = await (from u in db.Users where u.EMAIL == email && u.PASSWORD == password select u).FirstOrDefaultAsync();

            if (user != null)
            {
                HttpContext.Current.Session.Add("username", user.USERNAME);
                return Ok(new { msg = "Success" });
            }

            return BadRequest();
        }


        //public IHttpActionResult PutUser(decimal id, User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != user.USERID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}
    }
}
