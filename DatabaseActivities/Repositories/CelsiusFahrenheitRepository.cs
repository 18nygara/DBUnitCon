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

        public List<CelsiusFahrenheit>GetAllCelsiusFahrenheits()
        {
            return context.FahrenheitCelsiuses.ToList(); 
        }

        public void AddCelsiusFahrenheit(CelsiusFahrenheit toAdd)
        {
            context.FahrenheitCelsiuses.Add(toAdd);
            context.SaveChanges();
        }

        public void RemoveCelsiusFahrenheit(CelsiusFahrenheit toRemove)
        {
            context.FahrenheitCelsiuses.Remove(toRemove);
            context.SaveChanges();
        }

        public CelsiusFahrenheit GetCelsiusFahrenheitById(int id)
        {
            return context.FahrenheitCelsiuses.Find(id);
        }
    }
}