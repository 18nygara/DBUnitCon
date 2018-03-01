using DatabaseActivities.Models.Entity;
using DatabaseActivities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnitConV1.Controllers
{
    public class MileFathomController : Controller
    {
        private MileFathomService service;

        public MileFathomController()
        {
            service = new MileFathomService();
        }

        // GET: MileFathom
        public ActionResult Index()
        {
            return View(service.GetAllMileFathoms());
        }

        [HttpPost]
        public ActionResult MileToFathom(double mile)
        {
            double fathom = mile * 880;
            MileFathom test = new MileFathom();
            test.Mile = mile;
            test.Fathom = fathom;
            service.AddMileFathom(test);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult FathomtoMile(double fathom)
        {
            double mile = fathom / 880;
            MileFathom test = new MileFathom();
            test.Mile = mile;
            test.Fathom = fathom;
            service.AddMileFathom(test);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            MileFathom toDelete = service.GetMileFathomById(id);
            service.RemoveMileFathom(toDelete);
            return RedirectToAction("Index");
        }
    }
}