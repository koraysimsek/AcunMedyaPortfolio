using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            var values = db.Slider.ToList();
            return View(values);
        }
        public ActionResult DeleteSlider(int id)
        {
            var values = db.Slider.Find(id);
            db.Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(Slider slider)
        {
            db.Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var values = db.Slider.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSlider(Slider model)
        {
            var values = db.Slider.Find(model.SliderID);
            values.NameSurname = model.NameSurname;
            values.Description = model.Description;
            values.ImageURL = model.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}