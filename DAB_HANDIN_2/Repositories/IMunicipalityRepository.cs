using Covid19_Tracking.Domain;
using System.Collections.Generic;

namespace Covid19_Tracking.Persistence.Repositories
{
    public struct MunicipalityPair
    {
        public long infected;
        public Municipality municipality;
    }
    public interface IMunicipalityRepository
    {
        public IEnumerable<MunicipalityPair> GetInfectedByMunicipality();
    }
}