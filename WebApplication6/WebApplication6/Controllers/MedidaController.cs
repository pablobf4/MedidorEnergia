using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
  
    public class MedidaController : Controller
    {
    
          
        // GET: Medida
        public ActionResult Index()
        {

            return View();
        }

        // GET: Medida/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Medida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medida/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medida/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Medida/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medida/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Medida/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
