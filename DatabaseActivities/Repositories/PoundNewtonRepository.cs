using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;

namespace DatabaseActivities.Repositories
{
    public class PoundNewtonRepository
    {
        private ApplicationDbContext context;

        public PoundNewtonRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<PoundNewton> GetAllPoundNewtons()
        {
            return context.PoundNewtons.ToList();
        }

        public void AddPoundNewton(PoundNewton toAdd)
        {
            context.PoundNewtons.Add(toAdd);
            context.SaveChanges();
        }

        public void RemovePoundNewton(PoundNewton toDelete)
        {
            context.PoundNewtons.Remove(toDelete);
            context.SaveChanges();
        }

        public PoundNewton GetPoundNewtonById(int id)
        {
            return context.PoundNewtons.Find(id);
        }
    }
}