using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;

namespace DatabaseActivities.Services
{
    public class PoundNewtonService
    {
        private PoundNewtonRepository repository;

        public PoundNewtonService()
        {
            repository = new PoundNewtonRepository();
        }

        public List<PoundNewton> GetAllPoundNewtons()
        {
            return repository.GetAllPoundNewtons();
        }

        public void AddPoundNewton(PoundNewton toAdd)
        {
            repository.AddPoundNewton(toAdd);
        }

        public void RemovePoundNewton(PoundNewton toDelete)
        {
            repository.RemovePoundNewton(toDelete);
        }

        public PoundNewton GetPoundNewtonById(int id)
        {
            return repository.GetPoundNewtonById(id);
        }
    }
}