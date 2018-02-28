using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class MileFathom : IEntity
    {
        public int Id { get; set; }
        public double Mile { get; set; }
        public double Fathom { get; set; }
    }
}