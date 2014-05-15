using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEcole.Controllers
{
    [AllowAnonymous]
    public class LangueController : Controller
    {
        public ActionResult FromFrenchToEnglish()
        {
            HttpCookie cookie = new HttpCookie("langue", "en");
            cookie.Expires.AddMonths(12);
            Response.Cookies.Add(cookie);

            if (Request.UrlReferrer != null)
            {
                
                return Redirect(Request.UrlReferrer.PathAndQuery);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }
        public ActionResult FromEnglishToFrench()
        {
            HttpCookie cookie = new HttpCookie("langue", "fr");
            cookie.Expires.AddMonths(12);
            Response.Cookies.Add(cookie);

            if (Request.UrlReferrer != null)
            {
                return Redirect(Request.UrlReferrer.PathAndQuery);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
