using DatabaseActivities.Models.Entity;
using DatabaseActivities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class CelsiusFahrenheitController : Controller
    {
        private CelsiusFahrenheitService service;

        public CelsiusFahrenheitController()
        {
            service = new CelsiusFahrenheitService();
        }
        // GET: CelsiusFahrenheit
        public ActionResult Index()
        {
            return View(service.GetAllCelsiusFahrenheits());
        }
        [HttpPost]
        public ActionResult CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 1.8 + 32;
            CelsiusFahrenheit test = new CelsiusFahrenheit();
            test.Celsius = celsius;
            test.Fahrenheit = fahrenheit;
            service.AddCelsiusFahrenheit(test);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) / 1.8;
            CelsiusFahrenheit test = new CelsiusFahrenheit();
            test.Celsius = celsius;
            test.Fahrenheit = fahrenheit;
            service.AddCelsiusFahrenheit(test);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            CelsiusFahrenheit toDelete = service.GetCelsiusFahrenheitById(id);
            service.RemoveCelsiusFahrenheit(toDelete);
            return RedirectToAction("Index");
        }
    }
}