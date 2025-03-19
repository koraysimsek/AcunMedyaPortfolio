using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            var values = db.Skill.ToList();
            return View(values);
        }
        public ActionResult DeleteSkill(int id)
        {
            var values = db.Skill.Find(id);
            db.Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var values = db.Skill.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill model)
        {
            var values = db.Skill.Find(model.SkillID);
            values.SkillName = model.SkillName;
            values.Percentage = model.Percentage;
            values.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}