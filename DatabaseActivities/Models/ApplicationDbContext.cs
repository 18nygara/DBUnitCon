using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DatabaseActivities.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FeetMeter> FeetMeters { get; set; }
        public DbSet<CelsiusFahrenheit> FahrenheitCelsiuses { get; set; }
        public DbSet<MileFathom> MileFathoms { get; set; }
        public DbSet<PoundNewton> PoundNewtons { get; set; }
    }
}