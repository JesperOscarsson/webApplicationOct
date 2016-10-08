using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApplicationOct.Controllers
{
    public class HomeController : Controller
    {

        string secretMessage = "Skytte på banan";
        string secretMessage2 = "Markera på banan";
        
        // GET: Home
        public ActionResult Index()
        {
            return View(secretMessage);
        }

        public ActionResult About(string secretMessage)
        {
            return View();
        }
    }
}