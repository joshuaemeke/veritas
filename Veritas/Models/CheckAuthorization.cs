using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Routing;

namespace Veritas.Models
{
    public class CheckAuthorization : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string username = (string)HttpContext.Current.Session["username"];
            if (username == null)
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(
                   new RouteValueDictionary(
                    new { action = "Login", Controller = "Home" }));
            }
        }
    }
}