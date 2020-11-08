using Covid19_Tracking.Domain;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Persistence
{
    class PlutoContext
    {
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<CitizenLocation> CitizenLocations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<TestCenter> TestCenters { get; set; }
        public virtual DbSet<TestCenterManagement> TestCenterManagements { get; set; }
        public virtual DbSet<TestDate> TestDates { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


          
        //}

    }
}
