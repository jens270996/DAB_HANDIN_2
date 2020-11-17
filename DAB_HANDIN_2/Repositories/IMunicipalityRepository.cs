using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System.Collections.Generic;

namespace Covid19_Tracking.Persistence.Repositories
{
    public struct MunicipalityPair
    {
        public long infected;
        public Municipality municipality;
    }
    public interface IMunicipalityRepository:IRepository<Municipality>
    {
        public IEnumerable<MunicipalityPair> GetInfectedByMunicipality();
    }
}