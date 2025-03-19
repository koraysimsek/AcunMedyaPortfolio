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
    }
}