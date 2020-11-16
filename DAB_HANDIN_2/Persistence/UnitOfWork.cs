using Covid19_Tracking.Persistence.Repositories;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CovidContext _context;

        public UnitOfWork(CovidContext context)
        {
            _context = context;
            Citizens = new CitizenRepository(_context);
            Municipalities = new MunicipalityRepository(_context);
            TestCenters = new TestCenterRepository(_context);
            TestCenterManagements = new TestCenterManagementRepository(_context);
            TestDates = new TestDateRepository(_context);
            Locations = new LocationRepository(_context);
            //Courses = new CourseRepository(_context);
            //Authors = new AuthorRepository(_context);
        }

        public ICitizenRepository Citizens { get; private set; }
        public IMunicipalityRepository Municipalities {get; private set;}
        public ITestCenterManagementRepository TestCenterManagements { get; private set; }
        public Covid19_Tracking.Repositories.ITestCenterRepository TestCenters { get; private set; }
        public ITestDateRepository TestDates { get; private set; }

        public ILocationRepository Locations { get; private set; }
        //public ICourseRepository Courses { get; private set; }
        //public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
