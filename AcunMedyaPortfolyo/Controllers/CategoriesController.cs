using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Category.ToList();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = db.Category.Find(id);
            db.Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)  
        {
            var values = db.Category.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category model)
        {
            var values = db.Category.Find(model.CategoryID);
            values.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}