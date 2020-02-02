using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogTask.Controllers
{
    
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            ViewBag.Genders = new string[] { "Мужской", "Женский"};
            ViewBag.Languages = new string[] { "English", "Українська", "Русский","Deutsch", "Other" };
            return View();
        }
        [HttpGet]
        public ActionResult ProfileResult()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ProfileResult(string name, string surname, string birth, string gender, string country, string[] language)
        {
            ViewBag.Name = name;
            ViewBag.Surname = surname;
            ViewBag.Birth = birth;
            ViewBag.Gender = gender;
            ViewBag.Country = country;
            ViewBag.Language = language;
            return View();
        }

    }
}