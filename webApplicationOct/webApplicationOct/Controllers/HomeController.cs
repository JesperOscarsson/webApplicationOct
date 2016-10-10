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
        private List<object> ExperienceList;

        public HomeController()
        {
            ExperienceList = new List<object>();
            //Below add stuff to list
            ExperienceList.Add(new Education() { Course = "Placeholder1", Period = "1786 - 2016", School = "Östra" });
            ExperienceList.Add(new Education() { Course = "Placeholder2", Period = "1786 - 2016", School = "Östra" });
            ExperienceList.Add(new Education() { Course = "Placeholder3", Period = "1786 - 2016", School = "Östra" });
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
            return View(ExperienceList);
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}