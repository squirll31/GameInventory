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
    public class PlatformsController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: Platforms
        public ActionResult Index()
        {
            var platforms = db.Platforms.Include(p => p.GameCompany);
            return View(platforms.ToList());
        }

        // GET: Platforms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platform platform = db.Platforms.Find(id);
            if (platform == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameSearchResults = db.Games_SelectAllByPlatform(id).ToList();
            return View(platform);
        }

        // GET: Platforms/Create
        public ActionResult Create()
        {
            if (this.User.Identity.IsAuthenticated)
            {

                ViewBag.CompanyId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName");
            return View();
            }
            else {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
        }

        // POST: Platforms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlatformId,PlatformName,CompanyId")] Platform platform)
        {
            if (ModelState.IsValid)
            {
                db.Platforms.Add(platform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", platform.CompanyId);
            return View(platform);
        }

        // GET: Platforms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Platform platform = db.Platforms.Find(id);
                if (platform == null)
                {
                    return HttpNotFound();
                }
                ViewBag.CompanyId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", platform.CompanyId);
                return View(platform);
            }  else {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
        }

        // POST: Platforms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlatformId,PlatformName,CompanyId")] Platform platform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(platform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", platform.CompanyId);
            return View(platform);
        }

        // GET: Platforms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Platform platform = db.Platforms.Find(id);
                if (platform == null)
                {
                    return HttpNotFound();
                }
                return View(platform);
            } else {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
        }

        // POST: Platforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Platform platform = db.Platforms.Find(id);
            db.Platforms.Remove(platform);
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
