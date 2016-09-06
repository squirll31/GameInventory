using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameInventory;

namespace GameInventory.Controllers
{
    public class GameRegionsController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: GameRegions
        public ActionResult Index()
        {
            return View(db.GameRegions.ToList());
        }

        // GET: GameRegions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameRegion gameRegion = db.GameRegions.Find(id);
            if (gameRegion == null)
            {
                return HttpNotFound();
            }
            return View(gameRegion);
        }

        // GET: GameRegions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameRegions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameRegionId,GameRegionName")] GameRegion gameRegion)
        {
            if (ModelState.IsValid)
            {
                db.GameRegions.Add(gameRegion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameRegion);
        }

        // GET: GameRegions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameRegion gameRegion = db.GameRegions.Find(id);
            if (gameRegion == null)
            {
                return HttpNotFound();
            }
            return View(gameRegion);
        }

        // POST: GameRegions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameRegionId,GameRegionName")] GameRegion gameRegion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameRegion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameRegion);
        }

        // GET: GameRegions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameRegion gameRegion = db.GameRegions.Find(id);
            if (gameRegion == null)
            {
                return HttpNotFound();
            }
            return View(gameRegion);
        }

        // POST: GameRegions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameRegion gameRegion = db.GameRegions.Find(id);
            db.GameRegions.Remove(gameRegion);
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
