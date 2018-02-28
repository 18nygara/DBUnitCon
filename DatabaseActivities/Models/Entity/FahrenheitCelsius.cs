using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class FahrenheitCelsius :IEntity
    {
        public int Id { get; set; }
        public double Fahrenheit { get; set; }
        public double Celsius { get; set; }
    }
}