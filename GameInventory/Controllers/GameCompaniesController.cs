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
    public class GameCompaniesController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: GameCompanies
        public ActionResult Index()
        {
            return View(db.GameCompanies.ToList());
        }

        // GET: GameCompanies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameCompany gameCompany = db.GameCompanies.Find(id);
            if (gameCompany == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeveloperSearchResults = db.Games_SelectAllForDeveloper(id).ToList();
            ViewBag.PublisherSearchResults = db.Games_SelectAllForPublisher(id).ToList();
            return View(gameCompany);
        }

        // GET: GameCompanies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameCompanyId,GameCompanyName")] GameCompany gameCompany)
        {
            if (ModelState.IsValid)
            {
                db.GameCompanies.Add(gameCompany);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameCompany);
        }

        // GET: GameCompanies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameCompany gameCompany = db.GameCompanies.Find(id);
            if (gameCompany == null)
            {
                return HttpNotFound();
            }
            return View(gameCompany);
        }

        // POST: GameCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameCompanyId,GameCompanyName")] GameCompany gameCompany)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameCompany).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameCompany);
        }

        // GET: GameCompanies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameCompany gameCompany = db.GameCompanies.Find(id);
            if (gameCompany == null)
            {
                return HttpNotFound();
            }
            return View(gameCompany);
        }

        // POST: GameCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameCompany gameCompany = db.GameCompanies.Find(id);
            db.GameCompanies.Remove(gameCompany);
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
