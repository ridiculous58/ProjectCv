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
    public class ExperiencesController : Controller
    {
        // GET: Experiences
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            var model = context.Experiences.ToList();
            return View(model);
        }
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(Experience experience)
        {
            if(experience != null)
            {
                context.Experiences.Add(experience);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Experiences");
        }
        public ActionResult DeleteExperience(int id=-1)
        {
            if(id!=-1)
            {
                var model = context.Experiences.Find(id);
                if(model!=null)
                { 
                context.Experiences.Remove(model);
                context.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Experiences");
        }
        public ActionResult UpdateExperience(int id=-1)
        {
            
            if (id!=-1)
            {
                var model = context.Experiences.Find(id);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience experience)
        {
            if(experience!=null)
            {
                var model = context.Entry(experience);
                model.State = EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Experiences");
        }


    }
}