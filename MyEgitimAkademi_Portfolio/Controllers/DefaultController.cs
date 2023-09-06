using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialQuickContact()
        {
            var values = db.QuickContact.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFeature()
        {
            var values = db.Feature.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAwardInfo()
        {
            var values = db.AwardInfo.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAward()
        {
            var values = db.Awards.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonialInfo()
        {
            var values = db.TestimonialInfo.ToList();
            return PartialView(values);
        }


        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialClientInfo()
        {
            var values = db.ClientInfo.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialClientStats()
        {
            var values = db.ClientStats.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialClients()
        {
            var values = db.Clients.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult PartialContactInfo()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialContactInfo(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return PartialView();
        }

        public PartialViewResult PartialContact()
        {
            var values = db.Address.ToList();
            return PartialView(values);
        }
    }
}