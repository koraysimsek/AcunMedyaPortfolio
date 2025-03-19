using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.About.ToList();
            return View(values);
        }

        public ActionResult DeleteAbout(int id)
        {
            var values = db.About.Find(id);
            db.About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            db.About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.About.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About model)
        {
            var values = db.About.Find(model.AboutID);
            values.ImageURL = model.ImageURL;
            values.Title = model.Title;
            values.Birthday = model.Birthday;
            values.WebSite = model.WebSite;
            values.Phone = model.Phone;
            values.City = model.City;
            values.Age = model.Age;
            values.Freelance = model.Freelance;
            values.Description1 = model.Description1;
            values.Description2 = model.Description2;
            values.Degree = model.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}