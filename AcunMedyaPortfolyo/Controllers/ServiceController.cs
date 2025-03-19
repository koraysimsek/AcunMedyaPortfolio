using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServices(Services services)
        {
            db.Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = db.Services.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateServices(Services model)
        {
            var values = db.Services.Find(model.ServicesID);
            values.Description = model.Description;
            values.Title = model.Title;
            values.IconURL = model.IconURL;
            values.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}