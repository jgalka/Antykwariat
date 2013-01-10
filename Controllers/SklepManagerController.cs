using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antykwariat.Models;

namespace Antykwariat.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class SklepManagerController : Controller
    {
        private AntykwariatEntities db = new AntykwariatEntities();

        //
        // GET: /StoreManager/

        public ViewResult Index()
        {
            var ksiazki = db.Ksiazki.Include(a => a.Gatunek).Include(a => a.Autor);
            return View(ksiazki.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ViewResult Szczegoly(int id)
        {
            Ksiazka ksiazka = db.Ksiazki.Find(id);
            return View(ksiazka);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult NowyWpis()
        {
            ViewBag.GatunekId = new SelectList(db.Gatunki, "GatunekId", "Nazwa");
            ViewBag.AutorId = new SelectList(db.Autorzy, "AutorId", "Nazwa");
            return View();
        } 

        //
        // POST: /StoreManager/Create

        [HttpPost]
        public ActionResult NowyWpis(Ksiazka ksiazka)
        {
            if (ModelState.IsValid)
            {
                db.Ksiazki.Add(ksiazka);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.GatunekId = new SelectList(db.Gatunki, "GatunekId", "Nazwa", ksiazka.GatunekId);
            ViewBag.AutorId = new SelectList(db.Autorzy, "AutorId", "Nazwa", ksiazka.AutorId);
            return View(ksiazka);
        }
        
        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edytuj(int id)
        {
            Ksiazka ksiazka = db.Ksiazki.Find(id);
            ViewBag.GatunekId = new SelectList(db.Gatunki, "GatunekId", "Nazwa", ksiazka.GatunekId);
            ViewBag.AutorId = new SelectList(db.Autorzy, "AutorId", "Nazwa", ksiazka.AutorId);
            return View(ksiazka);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edytuj(Ksiazka ksiazka)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ksiazka).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GatunekId = new SelectList(db.Gatunki, "GatunekId", "Nazwa", ksiazka.GatunekId);
            ViewBag.AutorId = new SelectList(db.Autorzy, "AutorId", "Nazwa", ksiazka.AutorId);
            return View(ksiazka);
        }

        //
        // GET: /StoreManager/Delete/5
 
        public ActionResult Usun(int id)
        {
            Ksiazka ksiazka = db.Ksiazki.Find(id);
            return View(ksiazka);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Ksiazka ksiazka = db.Ksiazki.Find(id);
            db.Ksiazki.Remove(ksiazka);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}