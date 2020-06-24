using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PROYECTO_UNIDAD_III.Controllers
{
    public class AdminController : Controller
    {
        private ZapateriaYucEntities db = new ZapateriaYucEntities();
        private Empresa model;
        public AdminController()
        {
            List<Empresa> misionsList = db.Empresa.ToList();
            model = misionsList[0];
        }
        #region Mision
        public ActionResult Mision(string mensaje)
        {
            ViewBag.Message = mensaje;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMision([Bind(Include = "ID, Mision")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                model.Mision = empresa.Mision;
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Mision", "Admin", new { mensaje = "Mision modificada" });
        }
        #endregion
        #region Vision
        public ActionResult Vision(string mensaje)
        {
            ViewBag.Message = mensaje;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVision([Bind(Include = "ID, Vision")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                model.VIsion = empresa.VIsion;
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Vision", "Admin", new { mensaje = "Vision modificada" });
        }
        #endregion
        #region Nosotros
        public ActionResult Nosotros(string mensaje)
        {
            ViewBag.Message = mensaje;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditNosotros([Bind(Include = "ID, Nosotros")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                model.Nosotros = empresa.Nosotros;
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Nosotros", "Admin", new { mensaje = "Nosotros modificada" });
        }
        #endregion
        public ActionResult Portafolio()
        {
            return View();
        }

    }
}