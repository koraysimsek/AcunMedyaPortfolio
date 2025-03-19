using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Education.ToList();
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = db.Education.Find(id);
            db.Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(Education education)
        {
            db.Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values = db.Education.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateEducation(Education model)
        {
            var values = db.Education.Find(model.EducationID);
            values.StartYear = model.StartYear;
            values.EndYear = model.EndYear;
            values.Name = model.Name;
            values.Description = model.Description;
            values.Section = model.Section;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}