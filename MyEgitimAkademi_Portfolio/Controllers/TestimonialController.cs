using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestimonialInfo()
        {
            var values = db.TestimonialInfo.ToList();
            return View(values);
        }

        public ActionResult Testimonial()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            db.Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Testimonial");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonial.Find(id);
            db.Testimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Testimonial");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TestimonialInfo.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = db.Testimonial.Find(testimonial.TestimonialID);
            value.NameSurname = testimonial.NameSurname;
            value.ImageUrl = testimonial.ImageUrl;
            value.Comment = testimonial.Comment;
            value.Title = testimonial.Title;
            db.SaveChanges();
            return RedirectToAction("Testimonial");

        }

        [HttpGet]
        public ActionResult UpdateTestimonialInfo(int id)
        {
            var value = db.TestimonialInfo.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonialInfo(TestimonialInfo info)
        {
            var value = db.TestimonialInfo.Find(info.TestimonialID);
            value.SubjectText = info.SubjectText;
            db.SaveChanges();
            return RedirectToAction("TestimonialInfo");

        }
    }
}