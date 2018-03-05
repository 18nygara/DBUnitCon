using DatabaseActivities.Models.Entity;
using DatabaseActivities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnitConV1.Controllers
{
    public class FeetMeterController : Controller
    {
        private FeetMeterService service;

        public FeetMeterController()
        {
            service = new FeetMeterService();
        }
        // GET: FeetMeter
        public ActionResult Index()
        {
            return View(service.GetAllFeetMeters());

        }

        [HttpPost]
        public ActionResult FeettoMeter(double feet)
        {
            double meter = feet * 3.2808;
            FeetMeter test = new FeetMeter();
            test.Feet = feet;
            test.Meter = meter;
            service.AddFeetMeter(test);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult MetertoFeet(double meter)
        {
            double feet = meter / 3.2808;
            FeetMeter test = new FeetMeter();
            test.Feet = feet;
            test.Meter = meter;
            service.AddFeetMeter(test);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            FeetMeter toDelete = service.GetFeetMeterById(id);
            service.RemoveFeetMeter(toDelete);
            return RedirectToAction("Index");
        }
    }
}