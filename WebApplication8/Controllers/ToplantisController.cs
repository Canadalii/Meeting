using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class ToplantisController : Controller
    {
        private WebApplication8Context db = new WebApplication8Context();

        // GET: Toplantis
        public ActionResult Index()
        {
            return View(db.Toplantis.ToList());
        }

        // GET: Toplantis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toplanti toplanti = db.Toplantis.Find(id);
            if (toplanti == null)
            {
                return HttpNotFound();
            }
            return View(toplanti);
        }

        // GET: Toplantis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Toplantis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Konu,T_Tarih,BaslangicSaat,BitisSaat,Calisan,T_Katilimci")] Toplanti toplanti)
        {
            if (ModelState.IsValid)
            {
                db.Toplantis.Add(toplanti);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toplanti);
        }

        // GET: Toplantis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toplanti toplanti = db.Toplantis.Find(id);
            if (toplanti == null)
            {
                return HttpNotFound();
            }
            return View(toplanti);
        }

        // POST: Toplantis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Konu,T_Tarih,BaslangicSaat,BitisSaat,Calisan,T_Katilimci")] Toplanti toplanti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toplanti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toplanti);
        }

        // GET: Toplantis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toplanti toplanti = db.Toplantis.Find(id);
            if (toplanti == null)
            {
                return HttpNotFound();
            }
            return View(toplanti);
        }

        // POST: Toplantis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Toplanti toplanti = db.Toplantis.Find(id);
            db.Toplantis.Remove(toplanti);
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
