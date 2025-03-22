using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var deger = db.Services.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialContact()
        {
            var values = db.Contact.ToList();
            return PartialView(values);
        }

        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(Message message)
        {
            db.Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.About.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSlider()
        {
            var values = db.Slider.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values = db.Education.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialJob()
        {
            var values = db.Job.ToList();
            return PartialView(values);
        }
    }
}