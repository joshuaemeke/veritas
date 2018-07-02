using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using Veritas.Models;
using Veritas.Services;

namespace Veritas.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        VeritasServices services = new VeritasServices();
        portal_s_websure user = new portal_s_websure();

        [CheckAuthorization]
        public ActionResult Index()
        {
            //string username = (string)System.Web.HttpContext.Current.Session["username"];
            //if (username != null)
            //{
            //    return View();
            //}

            //return RedirectToAction("Login", "Home");

            //GET THE SESSION
            string username = (string)System.Web.HttpContext.Current.Session["username"];

            //GET THE CURRENT LOGGED IN USER FROM THE DATABASE
            var LoggedInUser = (from u in db.portal_s_websure where u.USERNAME == username select u).FirstOrDefault();

            //NOW LETS QUERY THE OTHER TABLE
            //GET ALL THE PAYMENTS AND COUNT THEM..IT IS THE SAME AS THIS
            //SELECT COUNT(PIN) FROM EXIT_PROCESS_PAYMENT WHERE PIN=?
            var processPayementSum = (from u in db.EXIT_PROCESS_PAYMENT where u.PIN == LoggedInUser.USERPIN select u).Count();

            //ACCORDING TO TAYO THIS IS THE NEXT STEP
            //if record exists then the customer is a Retiree and the scheme_id = 31

            int scheme_id = 0;
            if(processPayementSum > 0) //THIS MEANS IT EXIST SO SCHEME ID = 31
            {
                scheme_id = 31; //SET SCHEME ID TO 31
            }
            else
            {
                //else the customer is an Active Customer/RSA and the scheme_id = 1
                scheme_id = 1;

            }

            //NOW THAT YOU HAVE THE SCHEME ID, WHAT NEXT?
            //NOW LETS INFO FROM THE TABLE


            var employeContribu = (from x in db.CONTRIBUTIONs select x).FirstOrDefault();

            //MIND YOU, THIS WILL BE THE SAME FOR EVERY LOGGED IN USER
            //SINCE YOU HAVE REFUSED TO UNDERSTAND THE BUSINESS REQUIREMENTS
            //AND YOU MUST NOT DELETE THE COMMENTS IM PLACING HERE


            //NOW LETS SAVE IT
            TempData.Keep("contrib");
            TempData["contrib"] = employeContribu; //WE ARE SAVING THE RESULT HERE
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
           
            string username = (string)System.Web.HttpContext.Current.Session["username"];
            user = (from u in db.portal_s_websure where u.USERNAME == username select u).FirstOrDefault();
            TempData.Keep("profile");
            TempData["profile"] = user;
            return View();
        }

        public async Task<ActionResult> UpdateProfile([FromBody] portal_s_websure user)
        {
            var data = db.portal_s_websure.Find(user.USERID);

            //insert the username 
            data.FIRSTNAME = user.FIRSTNAME;

            db.Entry(data).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                string msg = ex.Message;
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }

        }

        public async Task<ActionResult> auth(string email, string password)
        {
            var user = (from u in db.portal_s_websure where u.EMAIL == email && u.PASSWORD == password select u).FirstOrDefault();

            if (user != null)
            {
                System.Web.HttpContext.Current.Session.Add("username", user.USERNAME);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Complaint()
        {
            ViewBag.Message = "Your Complaint";
            return View();
        }

        public ActionResult ContactForm()
        {
            ViewBag.Message = "Your Contact Form";
            return View();
        }

        public ActionResult ReferralForm()
        {
            ViewBag.Message = "Your Referral from";
            return View();
        }

        public ActionResult Support()
        {
            ViewBag.Message = "Your Support page";
            
            return View();
        }

        public ActionResult Fundsperformance()
        {
            ViewBag.Message = "Your funds performance";
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("login", "home");
        }

        public ActionResult Benefits()
        {
            ViewBag.Message = "Your Benefits Page";
            return View();
        }
    }





}
