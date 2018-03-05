using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories.FeetMeterRepository
{
    public class FeetMeterRepository
    {
        private ApplicationDbContext context;

        public FeetMeterRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<FeetMeter> GetAllFeetMeters()
        {
            return context.FeetMeters.ToList();
        }

        public void AddFeetMeter(FeetMeter toAdd)
        {
            context.FeetMeters.Add(toAdd);
            context.SaveChanges();
        }

        public void RemoveFeetMeter (FeetMeter toDelete)
        {
            context.FeetMeters.Remove(toDelete);
            context.SaveChanges();
        }

        public FeetMeter GetFeetMeterById(int id)
        {
            return context.FeetMeters.Find(id);
        }
    }
}