using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class PoundNewton :IEntity
    {
        public int Id { get; set; }
        public double Pound { get; set; }
        public double Newton { get; set; }
    }
}