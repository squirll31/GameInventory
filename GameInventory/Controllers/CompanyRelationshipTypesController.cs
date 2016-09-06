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
    public class CompanyRelationshipTypesController : Controller
    {
        private GameInventoryDBEntities db = new GameInventoryDBEntities();

        // GET: CompanyRelationshipTypes
        public ActionResult Index()
        {
            return View(db.CompanyRelationshipTypes.ToList());
        }

        // GET: CompanyRelationshipTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRelationshipType companyRelationshipType = db.CompanyRelationshipTypes.Find(id);
            if (companyRelationshipType == null)
            {
                return HttpNotFound();
            }
            return View(companyRelationshipType);
        }

        // GET: CompanyRelationshipTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompanyRelationshipTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyRelationshipTypeId,CompanyRelationshipTypeName")] CompanyRelationshipType companyRelationshipType)
        {
            if (ModelState.IsValid)
            {
                db.CompanyRelationshipTypes.Add(companyRelationshipType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companyRelationshipType);
        }

        // GET: CompanyRelationshipTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRelationshipType companyRelationshipType = db.CompanyRelationshipTypes.Find(id);
            if (companyRelationshipType == null)
            {
                return HttpNotFound();
            }
            return View(companyRelationshipType);
        }

        // POST: CompanyRelationshipTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyRelationshipTypeId,CompanyRelationshipTypeName")] CompanyRelationshipType companyRelationshipType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyRelationshipType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companyRelationshipType);
        }

        // GET: CompanyRelationshipTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRelationshipType companyRelationshipType = db.CompanyRelationshipTypes.Find(id);
            if (companyRelationshipType == null)
            {
                return HttpNotFound();
            }
            return View(companyRelationshipType);
        }

        // POST: CompanyRelationshipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyRelationshipType companyRelationshipType = db.CompanyRelationshipTypes.Find(id);
            db.CompanyRelationshipTypes.Remove(companyRelationshipType);
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
