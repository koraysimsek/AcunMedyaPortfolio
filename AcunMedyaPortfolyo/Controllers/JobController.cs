using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Job.ToList();
            return View(values);
        }
        public ActionResult DeleteJob(int id)
        {
            var values = db.Job.Find(id);
            db.Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateJob(Job job)
        {
            db.Job.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var values = db.Job.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateJob(Job model)
        {
            var values = db.Job.Find(model.JobID);
            values.Title = model.Title;
            values.StartDate = model.StartDate;
            values.EndDate = model.EndDate;
            values.CompanyName = model.CompanyName;
            values.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}