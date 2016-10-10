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
    public class GameOwnersController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: GameOwners
        public ActionResult Index()
        {
            return View(db.GameOwners.ToList());
        }

        // GET: GameOwners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameOwner gameOwner = db.GameOwners.Find(id);
            if (gameOwner == null)
            {
                return HttpNotFound();
            }
            return View(gameOwner);
        }

        // GET: GameOwners/Create
        public ActionResult Create()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return View();
            } else {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
        }

        // POST: GameOwners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameOwnerId,GameOwnerName,OwnerUserId")] GameOwner gameOwner)
        {
            if (ModelState.IsValid)
            {
                db.GameOwners.Add(gameOwner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameOwner);
        }

        // GET: GameOwners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                GameOwner gameOwner = db.GameOwners.Find(id);
                if (gameOwner == null)
                {
                    return HttpNotFound();
                }
                return View(gameOwner);
            } else {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }

        }

        // POST: GameOwners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameOwnerId,GameOwnerName,OwnerUserId")] GameOwner gameOwner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameOwner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameOwner);
        }

        // GET: GameOwners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                GameOwner gameOwner = db.GameOwners.Find(id);
                if (gameOwner == null)
                {
                    return HttpNotFound();
                }
                return View(gameOwner);
            } else {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
        }

        // POST: GameOwners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameOwner gameOwner = db.GameOwners.Find(id);
            db.GameOwners.Remove(gameOwner);
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
