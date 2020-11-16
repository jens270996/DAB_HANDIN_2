using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Queries.Core.Domain;
using Queries.Core.Repositories;

namespace Covid19_Tracking.Persistence.Repositories
{
    public class NationRepository : Repository<Nation>, INationRepository
    {
        public NationRepository(CovidContext context) : base(context)
        {
        }
        public IEnumerable<Citizen> GetInfectedCitizens(Nation nation)
        {
            
                
        }

        public CovidContext CovidContext
        {
            get { return Context as CovidContext; }
        }
    }
}
