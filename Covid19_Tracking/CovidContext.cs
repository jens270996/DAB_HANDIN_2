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

        //public virtual DbSet<Author> Authors { get; set; }
        //public virtual DbSet<CourseTags> CourseTags { get; set; }
        //public virtual DbSet<Course> Courses { get; set; }
        //public virtual DbSet<Cover> Covers { get; set; }
        //public virtual DbSet<Tag> Tags { get; set; }

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
