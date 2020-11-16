using Covid19_Tracking.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking
{
    public partial class CovidContext : DbContext
    {
        public CovidContext()
        {
        }

        public CovidContext(DbContextOptions<CovidContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<CitizenLocation> CitizenLocations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<TestCenter> TestCenters { get; set; }
        public virtual DbSet<TestCenterManagement> TestCenterManagements { get; set; }
        public virtual DbSet<TestDate> TestDates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PlutoContext1;Trusted_Connection=True;ConnectRetryCount=0");
            }
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            Seed(modelBuilder);


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


        private void Seed(ModelBuilder modelBuilder)
        {
            #region Add Tags
           
        

            
            #endregion
        }
    }
}
