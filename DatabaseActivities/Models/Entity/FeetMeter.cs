using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class FeetMeter :IEntity
    {
        public int Id { get; set; }
        public double Meter { get; set; }
        public double Feet { get; set; }
    }
}