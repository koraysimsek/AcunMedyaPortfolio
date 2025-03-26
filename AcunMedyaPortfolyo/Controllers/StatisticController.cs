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
            ViewBag.EducationCount = db.Education.Count();
            ViewBag.JobCount = db.Job.Count();
            ViewBag.LastProjectName = db.Project.OrderByDescending(p => p.ProjectID).FirstOrDefault()?.ProjectName;
            ViewBag.LastServiceName = db.Services.OrderByDescending(p => p.ServicesID).FirstOrDefault()?.Title;
            ViewBag.LastSkillName = db.Skill.OrderByDescending(p => p.SkillID).FirstOrDefault()?.SkillName;
            ViewBag.LastTestimonialName = db.Testimonial.OrderByDescending(p => p.TestimonialID).FirstOrDefault()?.TestimonialName;
            ViewBag.LastMessageName = db.Message.OrderByDescending(p => p.MessageID).FirstOrDefault()?.MessageContent;
            ViewBag.LastJobName = db.Job.OrderByDescending(p => p.JobID).FirstOrDefault()?.Title;
            ViewBag.LastCompanyName = db.Job.OrderByDescending(p => p.JobID).FirstOrDefault()?.CompanyName;
            ViewBag.LastEducationName = db.Education.OrderByDescending(p => p.EducationID).FirstOrDefault()?.Name;
            return View();
        }
    }
}