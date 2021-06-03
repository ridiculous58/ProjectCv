using ProjeCv.Models;
using ProjeCv.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            Model model = new Model();
            model.Abouts = context.Abouts.ToList();
            model.Awards = context.Awards.ToList();
            model.Experiences = context.Experiences.ToList();
            model.Educations = context.Educations.ToList();
            model.Interests = context.Interests.ToList();
            model.Skills = context.Skills.ToList();

            
            //var model = context.Abouts.ToList();
            return View(model);
        }
    }
}