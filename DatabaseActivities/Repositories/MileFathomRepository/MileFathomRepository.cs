using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories.MileFathomRepository
{
    public class MileFathomRepository
    {
        private ApplicationDbContext context;

        public MileFathomRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<MileFathom> GetAllMileFathoms()
        {
            return context.MileFathoms.ToList();
        }

        public void AddMileFathom(MileFathom toAdd)
        {
            context.MileFathoms.Add(toAdd);
            context.SaveChanges();
        }

        public void RemoveMileFathom(MileFathom toDelete)
        {
            context.MileFathoms.Remove(toDelete);
            context.SaveChanges();
        }

        public MileFathom GetMileFathomById(int id)
        {
            return context.MileFathoms.Find(id);
        }
    }
}