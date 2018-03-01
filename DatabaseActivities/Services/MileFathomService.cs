using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories.MileFathomRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Services
{
    public class MileFathomService
    {
        private MileFathomRepository repository;

        public MileFathomService()
        {
            repository = new MileFathomRepository();
        }

        public List<MileFathom> GetAllMileFathoms()
        {
            return repository.GetAllMileFathoms();
        }

        public void AddMileFathom(MileFathom toAdd)
        {
            repository.AddMileFathom(toAdd);
        }

        public void RemoveMileFathom(MileFathom toDelete)
        {
            repository.RemoveMileFathom(toDelete);
        }

        public MileFathom GetMileFathomById(int id)
        {
            return repository.GetMileFathomById(id);
        }
    }
}