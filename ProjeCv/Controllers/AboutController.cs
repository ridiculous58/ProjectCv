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
    public class AboutController : Controller
    {
        // GET: Admin
        DatabaseContext contex = new DatabaseContext();
        public ActionResult Index()
        {
            var model = contex.Abouts.ToList();
            return View(model);
        }
        public ActionResult AboutAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AboutAdd(About about)
        {
            if(about !=null)
            {
                contex.Abouts.Add(about);
                contex.SaveChanges();
            }
            return RedirectToAction("Index", "About");
        }
        public ActionResult DeleteAbout(int id)
        {

            var model = contex.Abouts.Find(id);
            if(model !=null)
            {
                contex.Abouts.Remove(model);
                contex.SaveChanges();
            }

            return RedirectToAction("Index", "About");
        }
        public ActionResult UpdateAbout(int id)
        {
            var model = contex.Abouts.SingleOrDefault(x => x.Id==id);
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            if(about!=null)
            {
                var model = contex.Entry(about);
                model.State = EntityState.Modified;
                contex.SaveChanges();
            }
            return RedirectToAction("Index", "About");
        }
    }
}