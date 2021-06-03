using ProjeCv.Models;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace ProjeCv.Controllers
{
    public class EducationsController : Controller
    {
        // GET: Educations
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            var model = context.Educations.ToList();
            return View(model);
        }
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(Education education)
        {
            if(education != null)
            {
                context.Educations.Add(education);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Educations");
        }
        public ActionResult DeleteEducation(int id)
        {
            var model = context.Educations.Find(id);
            context.Educations.Remove(model);
            context.SaveChanges();
            return RedirectToAction("Index", "Educations");
        }
        public ActionResult UpdateEducation(int id)
        {
            var model = context.Educations.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education education)
        {
            if(education!=null)
            {
                var model = context.Entry(education);
                model.State = EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Educations");
        }
    }
}