using Cars_Detail_Display.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cars_Detail_Display.Controllers
{
    public class CarsController : Controller
    {
        public ActionResult Index()
        {
            var cars = CarData.GetAll();
            return View(cars);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                CarData.Add(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }

        public ActionResult Delete(int id)
        {
            var car = CarData.Get(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarData.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var car = CarData.Get(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }
    }
}