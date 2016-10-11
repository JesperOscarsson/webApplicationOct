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
        private List<Experience> ExperienceList;

        public HomeController()
        {
            ExperienceList = new List<Experience>();
            //Below add stuff to list
            ExperienceList.Add(new Education() { Course = "Placeholder1", Period = "1786 - 2016", School = "Östra" });
            ExperienceList.Add(new Education() { Course = "Placeholder2", Period = "1786 - 2016", School = "Östra" });
            ExperienceList.Add(new Education() { Course = "Placeholder3", Period = "1786 - 2016", School = "Östra" });
            ExperienceList.Add(new TechnicalKnowledge() { Skill = "Placeholder4", Proficiency = "Ok" });
            ExperienceList.Add(new TechnicalKnowledge() { Skill = "Placeholder5", Proficiency = "Ok" });
            ExperienceList.Add(new CommonKnowledge() { CommonSkill = "Placeholder6", CommonProficiency = "Ok" });
            ExperienceList.Add(new CommonKnowledge() { CommonSkill = "Placeholder7", CommonProficiency = "Ok" });
            ExperienceList.Add(new CommonKnowledge() { CommonSkill = "Placeholder8", CommonProficiency = "Ok" });
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