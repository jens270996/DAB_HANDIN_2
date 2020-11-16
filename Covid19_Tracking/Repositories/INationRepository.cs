using Covid19_Tracking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Repositories
{
    public interface INationRepository: IRepository<Nation>
    {

        public IEnumerable<Citizen> GetInfectedCitizens(Nation nation);
    }
}
