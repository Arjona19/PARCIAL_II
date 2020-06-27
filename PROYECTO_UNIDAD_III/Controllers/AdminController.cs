using AutoMapper;
using PROYECTO_UNIDAD_III.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
        private List<Portafolio> listPortafolio;
        private PortafolioPartialModel autoMapPortafolioModel;
        private IMapper map;
        public AdminController()
        {
            List<Empresa> misionsList = db.Empresa.ToList();
            model = misionsList[0];
            listPortafolio = db.Portafolio.ToList();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Portafolio, PortafolioPartialModel>();
            });

            map = config.CreateMapper();
            autoMapPortafolioModel = map.Map<Portafolio, PortafolioPartialModel>(autoMapPortafolioModel = new PortafolioPartialModel());
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
        #region Portafolio
        public ActionResult Portafolio(string mensaje)
        {
            ViewBag.Message = mensaje;
            return View(listPortafolio);
        }

        
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portafolio portafolio = db.Portafolio.Find(id);
           
            if (portafolio == null)
            {
                return HttpNotFound();
            }
            autoMapPortafolioModel = map.Map<Portafolio, PortafolioPartialModel>(portafolio);
            return View(autoMapPortafolioModel);
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCreate([Bind(Include = "NombreProducto, Detalles, Precio")] PortafolioPartialModel autoMapPortafolioModel)
        {
            HttpPostedFileBase file = Request.Files[0];
            
            if (ModelState.IsValid)
            {
                autoMapPortafolioModel.Fotos64 = file;
                byte[] foto = autoMapPortafolioModel.GetByte64File;
                Portafolio model = new Portafolio();
                model.Foto = foto;
                model.NombreProducto = autoMapPortafolioModel.NombreProducto;
                model.Detalles = autoMapPortafolioModel.Detalles;
                model.Precio = autoMapPortafolioModel.Precio;
                db.Portafolio.Add(model);
                db.SaveChanges();

            }
            return RedirectToAction("Portafolio", "Admin", new { mensaje = "PRODUCTO REGISTRADO CON EXITO" });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditModify([Bind(Include = "id, NombreProducto, Detalles, Precio")] PortafolioPartialModel autoMapPortafolioModel)
        {
            HttpPostedFileBase file = Request.Files[0];
            
            if (ModelState.IsValid)
            {
                autoMapPortafolioModel.Fotos64 = file;
                byte[] foto = autoMapPortafolioModel.GetByte64File;
                Portafolio model = new Portafolio();
                model.id = autoMapPortafolioModel.id;
                model.Foto = foto;
                model.NombreProducto = autoMapPortafolioModel.NombreProducto;
                model.Detalles = autoMapPortafolioModel.Detalles;
                model.Precio = autoMapPortafolioModel.Precio;
                db.Set<Portafolio>().AddOrUpdate(model);
                db.SaveChanges();

            }
            return RedirectToAction("Portafolio", "Admin", new { mensaje = "PRODUCTO MODIFICADO CON EXITO" });
        }

        #endregion
    }
}