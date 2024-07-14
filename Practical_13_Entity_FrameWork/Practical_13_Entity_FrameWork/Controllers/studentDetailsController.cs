using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practical_13_Entity_FrameWork.Models;

namespace Practical_13_Entity_FrameWork.Controllers
{
    public class studentDetailsController : Controller
    {
        private studentDBEntities1 db = new studentDBEntities1();

        // GET: studentDetails
        public ActionResult Index()
        {
            return View(db.studentDetails.ToList());
        }

        // GET: studentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studentDetail studentDetail = db.studentDetails.Find(id);
            if (studentDetail == null)
            {
                return HttpNotFound();
            }
            return View(studentDetail);
        }

        // GET: studentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studentDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,age,gender,grade")] studentDetail studentDetail)
        {
            if (ModelState.IsValid)
            {
                db.studentDetails.Add(studentDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentDetail);
        }

        // GET: studentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studentDetail studentDetail = db.studentDetails.Find(id);
            if (studentDetail == null)
            {
                return HttpNotFound();
            }
            return View(studentDetail);
        }

        // POST: studentDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,age,gender,grade")] studentDetail studentDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentDetail);
        }

        // GET: studentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studentDetail studentDetail = db.studentDetails.Find(id);
            if (studentDetail == null)
            {
                return HttpNotFound();
            }
            return View(studentDetail);
        }
        // POST: studentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            studentDetail studentDetail = db.studentDetails.Find(id);
            db.studentDetails.Remove(studentDetail);
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
