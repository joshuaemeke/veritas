using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veritas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string username = (string)System.Web.HttpContext.Current.Session["username"];
            if(username != null)
            {
                return View();
            }

            return View("~/Views/Home/Login.cshtml");

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}