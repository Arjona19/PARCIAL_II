using PROYECTO_UNIDAD_III.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace PROYECTO_UNIDAD_III.Controllers
{
    public class HomeController : Controller
    {
        private ZapateriaYucEntities db = new ZapateriaYucEntities();
        private Empresa model;
        public HomeController()
        {
            List<Empresa> misionsList = db.Empresa.ToList();
            model = misionsList[0];
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult Nosotros()
        {
            return View(model);
        }

        public ActionResult Mision()
        {
            return View(model);
        }
        public ActionResult Vision()
        {
            return View(model);
        }
        public ActionResult Portafolio()
        {
            return View();
        }


    }
}