using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webApplicationOct.Models;

namespace webApplicationOct.Controllers
{
    public class HomeController : Controller
    {

        WEBAPPDBEntities DataBase = new WEBAPPDBEntities();

        public HomeController()
        {  
        }       
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Qualifications()
        {
            return View(DataBase);
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}