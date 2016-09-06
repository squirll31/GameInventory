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
    public class CompanyRelationshipsController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: CompanyRelationships
        public ActionResult Index()
        {
            var companyRelationships = db.CompanyRelationships.Include(c => c.GameCompany).Include(c => c.GameCompany1).Include(c => c.CompanyRelationshipType);
            return View(companyRelationships.ToList());
        }

        // GET: CompanyRelationships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRelationship companyRelationship = db.CompanyRelationships.Find(id);
            if (companyRelationship == null)
            {
                return HttpNotFound();
            }
            return View(companyRelationship);
        }

        // GET: CompanyRelationships/Create
        public ActionResult Create()
        {
            ViewBag.FromCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName");
            ViewBag.ToCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName");
            ViewBag.CompanyRelationshipTypeId = new SelectList(db.CompanyRelationshipTypes, "CompanyRelationshipTypeId", "CompanyRelationshipTypeName");
            return View();
        }

        // POST: CompanyRelationships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyRelationshipId,CompanyRelationshipTypeId,FromCompany,ToCompany")] CompanyRelationship companyRelationship)
        {
            if (ModelState.IsValid)
            {
                db.CompanyRelationships.Add(companyRelationship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FromCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", companyRelationship.FromCompany);
            ViewBag.ToCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", companyRelationship.ToCompany);
            ViewBag.CompanyRelationshipTypeId = new SelectList(db.CompanyRelationshipTypes, "CompanyRelationshipTypeId", "CompanyRelationshipTypeName", companyRelationship.CompanyRelationshipTypeId);
            return View(companyRelationship);
        }

        // GET: CompanyRelationships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRelationship companyRelationship = db.CompanyRelationships.Find(id);
            if (companyRelationship == null)
            {
                return HttpNotFound();
            }
            ViewBag.FromCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", companyRelationship.FromCompany);
            ViewBag.ToCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", companyRelationship.ToCompany);
            ViewBag.CompanyRelationshipTypeId = new SelectList(db.CompanyRelationshipTypes, "CompanyRelationshipTypeId", "CompanyRelationshipTypeName", companyRelationship.CompanyRelationshipTypeId);
            return View(companyRelationship);
        }

        // POST: CompanyRelationships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyRelationshipId,CompanyRelationshipTypeId,FromCompany,ToCompany")] CompanyRelationship companyRelationship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyRelationship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FromCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", companyRelationship.FromCompany);
            ViewBag.ToCompany = new SelectList(db.GameCompanies, "GameCompanyId", "GameCompanyName", companyRelationship.ToCompany);
            ViewBag.CompanyRelationshipTypeId = new SelectList(db.CompanyRelationshipTypes, "CompanyRelationshipTypeId", "CompanyRelationshipTypeName", companyRelationship.CompanyRelationshipTypeId);
            return View(companyRelationship);
        }

        // GET: CompanyRelationships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRelationship companyRelationship = db.CompanyRelationships.Find(id);
            if (companyRelationship == null)
            {
                return HttpNotFound();
            }
            return View(companyRelationship);
        }

        // POST: CompanyRelationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyRelationship companyRelationship = db.CompanyRelationships.Find(id);
            db.CompanyRelationships.Remove(companyRelationship);
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
