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
    public class InterestsController : Controller
    {
        // GET: Interests
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            var model = context.Interests.ToList();
            return View(model);
        }
        public ActionResult AddInterest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInterest(Interest interest)
        {
            if(interest!=null)
            {
                context.Interests.Add(interest);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Interests");
        }

        public ActionResult UpdateInterest(int id=-1)
        {
            if(id!=-1)
            {
                var model = context.Interests.Find(id);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public ActionResult UpdateInterest(Interest interest)
        {
            if(interest!=null)
            {
                var model = context.Entry(interest);
                model.State = EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Interests");
        }
        public ActionResult DeleteInterest(int id=-1)
        {
            if(id!=-1)
            {
                var model = context.Interests.Find(id);
                context.Interests.Remove(model);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Interests");
        }
        
    }
}