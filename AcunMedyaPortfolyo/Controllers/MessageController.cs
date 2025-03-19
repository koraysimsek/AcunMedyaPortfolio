using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Message.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = db.Message.Find(id);
            db.Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMessage(Message message)
        {
            db.Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var values = db.Message.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateMessage(Message model)
        {
            var values = db.Message.Find(model.MessageID);
            values.NameSurname = model.NameSurname;
            values.Email = model.Email;
            values.Subject = model.Subject;
            values.MessageContent = model.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}