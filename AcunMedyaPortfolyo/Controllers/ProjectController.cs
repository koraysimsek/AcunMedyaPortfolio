using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.Project.Find(id);
            db.Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.Project.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProject(Project model)
        {
            var values = db.Project.Find(model.ProjectID);
            values.ProjectName = model.ProjectName;
            values.Description = model.Description;
            values.ProjectLink = model.ProjectLink;
            values.Image1 = model.Image1;
            values.Image2 = model.Image2;
            values.Image3 = model.Image3;
            values.CategoryID = model.CategoryID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}