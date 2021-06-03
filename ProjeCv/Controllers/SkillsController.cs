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
    public class SkillsController : Controller
    {
        // GET: Skills
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            var model = context.Skills.ToList();
            return View(model);
        }
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            if(skill!=null)
            {
                context.Skills.Add(skill);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Skills");
        }
        public ActionResult UpdateSkill(int id=-1)
        {
            if(id!=-1)
            {
                var model = context.Skills.Find(id);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            if(skill!=null)
            {
                var model = context.Entry(skill);
                model.State = EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Skills");
        }
        public ActionResult DeleteSkill(int id=-1)
        {
            if(id!=-1)
            {
                var model = context.Skills.Find(id);
                context.Skills.Remove(model);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Skills");
        }

    }
}