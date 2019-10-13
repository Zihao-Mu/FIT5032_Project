using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FIT5032_Project.Models;

namespace FIT5032_Project.Controllers
{
    public class DiningTablesController : Controller
    {
        private Entities db = new Entities();

        // GET: DiningTables
        public ActionResult Index()
        {
            return View(db.DiningTable.ToList());
        }

        // GET: DiningTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiningTable diningTable = db.DiningTable.Find(id);
            if (diningTable == null)
            {
                return HttpNotFound();
            }
            return View(diningTable);
        }

        // GET: DiningTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiningTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TableId,Location,Size,HalfPriceDate")] DiningTable diningTable)
        {
            if (ModelState.IsValid)
            {
                db.DiningTable.Add(diningTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diningTable);
        }

        // GET: DiningTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiningTable diningTable = db.DiningTable.Find(id);
            if (diningTable == null)
            {
                return HttpNotFound();
            }
            return View(diningTable);
        }

        // POST: DiningTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TableId,Location,Size,HalfPriceDate")] DiningTable diningTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diningTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diningTable);
        }

        // GET: DiningTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiningTable diningTable = db.DiningTable.Find(id);
            if (diningTable == null)
            {
                return HttpNotFound();
            }
            return View(diningTable);
        }

        // POST: DiningTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiningTable diningTable = db.DiningTable.Find(id);
            db.DiningTable.Remove(diningTable);
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
