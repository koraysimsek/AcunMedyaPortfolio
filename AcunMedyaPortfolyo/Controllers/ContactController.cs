using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DBAcunMedyaProject1Entities2 db = new DBAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.Contact.Find(id);
            db.Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = db.Contact.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact model)
        {
            var values = db.Contact.Find(model.ContactID);
            values.Description = model.Description;
            values.Address = model.Address;
            values.Email = model.Email;
            values.Phone = model.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}