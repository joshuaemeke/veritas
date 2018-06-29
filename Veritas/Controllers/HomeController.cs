using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Veritas.Models;
using Veritas.Services;

namespace Veritas.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        VeritasServices services = new VeritasServices();

        [CheckAuthorization]
        public ActionResult Index()
        {
            //string username = (string)System.Web.HttpContext.Current.Session["username"];
            //if (username != null)
            //{
            //    return View();
            //}

            //return RedirectToAction("Login", "Home");
            return View();
        }

        public ActionResult Login()
        {
            

            //return RedirectToAction("Home", "Login");

            return View();
        }

        [CheckAuthorization]
        public ActionResult Profile()
        {
            return View();
        }


        public async Task<ActionResult> auth(string email, string password)
        {
            var user = (from u in db.Users where u.EMAIL == email && u.PASSWORD == password select u).FirstOrDefault();

            if (user != null)
            {
                System.Web.HttpContext.Current.Session.Add("username", user.USERNAME);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
    }
}
