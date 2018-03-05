using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories.FeetMeterRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Services
{
    public class FeetMeterService
    {
        private FeetMeterRepository repository;

        public FeetMeterService()
        {
            repository = new FeetMeterRepository();
        }
        public List<FeetMeter> GetAllFeetMeters()
        {
            return repository.GetAllFeetMeters();
        }

        public void AddFeetMeter(FeetMeter toAdd)
        {
            repository.AddFeetMeter(toAdd);
        }

        public void RemoveFeetMeter(FeetMeter toDelete)
        {
            repository.RemoveFeetMeter(toDelete);
        }

        public FeetMeter GetFeetMeterById(int id)
        {
            return repository.GetFeetMeterById(id);
        }
    }
}