using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veritas.Models;

namespace Veritas.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            string username = (string)System.Web.HttpContext.Current.Session["username"];
            if (username != null)
            {
                return View();
            }

            return View("~/Views/Home/Login.cshtml");
        }

        public ActionResult Login(string email, string password)
        {
            var user =  (from u in db.Users where u.EMAIL == email && u.PASSWORD == password select u).FirstOrDefault();

            if (user != null)
            {
                System.Web.HttpContext.Current.Session.Add("username", user.USERNAME);
                return View("~/Views/Home/Index.cshtml");
            }

            return View("~/Views/Home/Login.cshtml");
        }
    }
}
