using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Services
{
    public class CelsiusFahrenheitService : Controller
    {
        private CelsiusFahrenheitRepository repository;

        public CelsiusFahrenheitService()
        {
            repository = new CelsiusFahrenheitRepository();
        }

        public List<CelsiusFahrenheit> GetAllCelsiusFahrenheits()
        {
            return repository.GetAllCelsiusFahrenheits();
        }

        public void AddCelsiusFahrenheit(CelsiusFahrenheit toAdd)
        {
            repository.AddCelsiusFahrenheit(toAdd);
        }

        public void RemoveCelsiusFahrenheit(CelsiusFahrenheit toRemove)
        {
            repository.RemoveCelsiusFahrenheit(toRemove);
        }

        public CelsiusFahrenheit GetCelsiusFahrenheitById(int id)
        {
            return repository.GetCelsiusFahrenheitById(id);
        }
    }
}