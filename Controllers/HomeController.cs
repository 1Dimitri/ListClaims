using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IdentityModel;
using System.Security.Claims;
using System.Threading;

namespace ListClaims.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ClaimsPrincipal userClaims = Thread.CurrentPrincipal as ClaimsPrincipal;
            // ViewBag.Claims = userClaims;
            return View(userClaims);

        }
/* public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
 * */
    }
 
}