using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.Category.Count();
            ViewBag.TestimonialCount = db.Testimonial.Count();
            ViewBag.MessageCount = db.Message.Count();
            ViewBag.SkillCount = db.Skill.Count();
            ViewBag.ServicesCount = db.Services.Count();
            ViewBag.ProjectCount = db.Project.Count();
            return View();
        }
    }
}