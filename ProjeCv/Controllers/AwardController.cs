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
    public class AwardController : Controller
    {
        // GET: Award
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            var model = context.Awards.ToList();
            return View(model);
        }
        public ActionResult AddAward()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAward(Award award)
        {
            if(award!= null)
            {
                context.Awards.Add(award);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Award");
        }
        public ActionResult DeleteAward(int id)
        {
            var model = context.Awards.Find(id);
            context.Awards.Remove(model);
            context.SaveChanges();
            
            return RedirectToAction("Index", "Award");
        }
        public ActionResult UpdateAward(int id)
        {
            var model = context.Awards.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateAward(Award award)
        {
            var model = context.Entry(award);
            model.State = EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("Index", "Award");
        }
    }
}