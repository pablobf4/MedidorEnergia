using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ObjetoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Objetoes
        public ActionResult Index()
        {
            return View(db.Objetos.ToList());
        }

        // GET: Objetoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Objeto objeto = db.Objetos.Find(id);
            if (objeto == null)
            {
                return HttpNotFound();
            }
            return View(objeto);
        }

        // GET: Objetoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Objetoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDObjeto,Nome")] Objeto objeto)
        {
            if (ModelState.IsValid)
            {
                db.Objetos.Add(objeto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objeto);
        }

        // GET: Objetoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Objeto objeto = db.Objetos.Find(id);
            if (objeto == null)
            {
                return HttpNotFound();
            }
            return View(objeto);
        }

        // POST: Objetoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDObjeto,Nome")] Objeto objeto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(objeto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(objeto);
        }

        // GET: Objetoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Objeto objeto = db.Objetos.Find(id);
            if (objeto == null)
            {
                return HttpNotFound();
            }
            return View(objeto);
        }

        // POST: Objetoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Objeto objeto = db.Objetos.Find(id);
            db.Objetos.Remove(objeto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
