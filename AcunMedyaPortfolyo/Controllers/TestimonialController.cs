using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Testimonial.Find(id);
            db.Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            db.Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Testimonial.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial model)
        {
            var values = db.Testimonial.Find(model.TestimonialID);
            values.Description1 = model.Description1;
            values.TestimonialName = model.TestimonialName;
            values.Description2 = model.Description2;
            values.ImageURL = model.ImageURL;
            values.Title = model.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}