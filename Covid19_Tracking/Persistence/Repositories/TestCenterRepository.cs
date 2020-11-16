using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Persistence.Repositories
{
    public class TestCenterRepository : Repository<TestCenter>, ITestCenterRepository
    {
        public TestCenterRepository(CovidContext context) : base(context)
        { }

    }
}
