using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Repositories
{
    public class CelsiusFahrenheitRepository : Controller
    {
        private ApplicationDbContext context;

        public CelsiusFahrenheitRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<FahrenheitCelsius> GetAllCelsiusFahrenheits()
        {
            return context.FahrenheitCelsiuses.ToList();
        }

        public void AddCelsiusFahrenheit(FahrenheitCelsius toAdd)
        {
            context.FahrenheitCelsiuses.Add(toAdd);
            context.SaveChanges();
        }

        public void RemoveCelsiusFahrenheit(FahrenheitCelsius toRemove)
        {
            context.FahrenheitCelsiuses.Remove(toRemove);
            context.SaveChanges();
        }

        public FahrenheitCelsius GetCelsiusFahrenheitById(int id)
        {
            return context.FahrenheitCelsiuses.Find(id);
        }
    }
}
