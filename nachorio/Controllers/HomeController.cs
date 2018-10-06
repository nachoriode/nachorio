using nachorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nachorio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aboutme()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Education()
        {
            return View();
        }
        public JsonResult DataEducation(int id)
        {
            estudiosContext estudios = new estudiosContext();
            var x = estudios.estudios.Join(estudios.actitudes, a => a.id, d => d.estudios.id, (a, d) =>d).Where(d => d.estudios.id == id).Select(a=>new { a.estudios, a.Nivel, a.Tipo, a.id }).ToList();
            return Json(estudios.estudios.Join(estudios.actitudes, a => a.id, d => d.estudios.id, (a, d) => d).Where(d => d.estudios.id == id).Select(a => new { a.estudios, a.Nivel, a.Tipo, a.id }).ToList(), JsonRequestBehavior.AllowGet);
           
        }

        public ActionResult Experience()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}