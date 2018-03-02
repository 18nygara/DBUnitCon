using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseActivities.Models.Entity;
using DatabaseActivities.Services;

namespace DatabaseActivities.Controllers
{
    public class PoundNewtonController : Controller
    {
        private PoundNewtonService service;

        public PoundNewtonController()
        {
            service = new PoundNewtonService();
        }
        // GET: PoundNewton
        public ActionResult Index()
        {
            return View(service.GetAllPoundNewtons());
        }

        [HttpPost]
        public ActionResult PoundToNewton(double pound)
        {
            double newton = pound * 4.44822;
            PoundNewton test = new PoundNewton();
            test.Pound = pound;
            test.Newton = newton;
            service.AddPoundNewton(test);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult NewtonToPound(double newton)
        {
            double pound = newton / 4.44822;
            PoundNewton test = new PoundNewton();
            test.Pound = pound;
            test.Newton = newton;
            service.AddPoundNewton(test);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            PoundNewton toDelete = service.GetPoundNewtonById(id);
            service.RemovePoundNewton(toDelete);
            return RedirectToAction("Index");
        }
    }
}