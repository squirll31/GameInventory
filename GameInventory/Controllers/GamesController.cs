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
    public class GamesController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: Games
        public ActionResult Index()
        {
            var games = db.Games.Include(g => g.GameCompany).Include(g => g.GameCompany1).Include(g => g.GameRegion).Include(g => g.Platform).Include(g => g.GameOwner);
            return View(games.ToList());
        }

        // GET: Games/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Games/Create
        public ActionResult Create()
        {
            ViewBag.DeveloperId = new SelectList(db.GameCompanies.OrderBy(m => m.GameCompanyName), "GameCompanyId", "GameCompanyName");
            ViewBag.PublisherId = new SelectList(db.GameCompanies.OrderBy(m => m.GameCompanyName), "GameCompanyId", "GameCompanyName");
            ViewBag.RegionId = new SelectList(db.GameRegions.OrderBy(m => m.GameRegionName), "GameRegionId", "GameRegionName");
            ViewBag.PlatformId = new SelectList(db.Platforms.OrderBy(m => m.PlatformName), "PlatformId", "PlatformName");
            ViewBag.OwnerId = new SelectList(db.GameOwners.OrderBy(m => m.GameOwnerName), "GameOwnerId", "GameOwnerName");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameId,PlatformId,Title,DeveloperId,RegionId,PublisherId,HasCase,HasManual,ModelName,HasAccessory,OwnerId,Notes")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DeveloperId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", game.DeveloperId);
            ViewBag.PublisherId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", game.PublisherId);
            ViewBag.RegionId = new SelectList(db.GameRegions, "GameRegionId", "GameRegionName", game.RegionId);
            ViewBag.PlatformId = new SelectList(db.Platforms, "PlatformId", "PlatformName", game.PlatformId);
            ViewBag.OwnerId = new SelectList(db.GameOwners, "GameOwnerId", "GameOwnerName", game.OwnerId);
            return View(game);
        }

        // GET: Games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeveloperId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", game.DeveloperId);
            ViewBag.PublisherId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", game.PublisherId);
            ViewBag.RegionId = new SelectList(db.GameRegions, "GameRegionId", "GameRegionName", game.RegionId);
            ViewBag.PlatformId = new SelectList(db.Platforms, "PlatformId", "PlatformName", game.PlatformId);
            ViewBag.OwnerId = new SelectList(db.GameOwners, "GameOwnerId", "GameOwnerName", game.OwnerId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameId,PlatformId,Title,DeveloperId,RegionId,PublisherId,HasCase,HasManual,ModelName,HasAccessory,OwnerId,Notes")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeveloperId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", game.DeveloperId);
            ViewBag.PublisherId = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", game.PublisherId);
            ViewBag.RegionId = new SelectList(db.GameRegions, "GameRegionId", "GameRegionName", game.RegionId);
            ViewBag.PlatformId = new SelectList(db.Platforms, "PlatformId", "PlatformName", game.PlatformId);
            ViewBag.OwnerId = new SelectList(db.GameOwners, "GameOwnerId", "GameOwnerName", game.OwnerId);
            return View(game);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
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
