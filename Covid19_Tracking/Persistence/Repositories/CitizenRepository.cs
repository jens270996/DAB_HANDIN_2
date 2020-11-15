using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Persistence.Repositories
{
    public class CitizenRepository : Repository<Citizen>, ICitizenRepository
    {
        public CitizenRepository(CovidContext context) : base(context)
        {
        }
        public IEnumerable<Citizen> GetPossibleInfectedCitizens(Citizen infected)
        {
            throw (new NotImplementedException());
        }
    }
}
