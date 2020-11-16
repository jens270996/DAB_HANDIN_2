using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Persistence.Repositories
{
    public class TestCenterManagementRepository : Repository<TestCenterManagement>, ITestCenterManagementRepository
    {
        public TestCenterManagementRepository(CovidContext context) : base(context)
        { }

    }
}
