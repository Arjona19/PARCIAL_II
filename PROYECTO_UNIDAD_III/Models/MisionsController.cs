using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PROYECTO_UNIDAD_III;

namespace PROYECTO_UNIDAD_III.Models
{
    public class MisionsController : Controller
    {
        //private ZapateriaEntities db = new ZapateriaEntities();

        //// GET: Misions
        //public ActionResult Index()
        //{
        //    return View(db.Mision.ToList());
        //}

        //// GET: Misions/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Mision mision = db.Mision.Find(id);
        //    if (mision == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mision);
        //}

        //// GET: Misions/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Misions/Create
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Nombre")] Mision mision)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Mision.Add(mision);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(mision);
        //}

        //// GET: Misions/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Mision mision = db.Mision.Find(id);
        //    if (mision == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mision);
        //}

        //// POST: Misions/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Nombre")] Mision mision)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(mision).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(mision);
        //}

        //// GET: Misions/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Mision mision = db.Mision.Find(id);
        //    if (mision == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mision);
        //}

        //// POST: Misions/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Mision mision = db.Mision.Find(id);
        //    db.Mision.Remove(mision);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
