using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Covid19_Tracking.Persistence.Repositories
{
    public class MunicipalityRepository : Repository<Municipality>, IMunicipalityRepository
    {
        public MunicipalityRepository(CovidContext context) : base(context)
        {
        }
        

        public CovidContext CovidContext
        {
            get { return Context as CovidContext; }
        }

        public IEnumerable<MunicipalityPair> GetInfectedByMunicipality()
        {
            List<MunicipalityPair> pairs = new List<MunicipalityPair>();
            foreach(var m in CovidContext.Municipalities.Include(c=>c))
            {
                var pair=new MunicipalityPair();
                pair.municipality = m;

                pair.infected=m.Citizens.Where(c => c.TestDates.Where(t => (t.Result == true) && (t.Date - DateTime.Today < TimeSpan.FromDays(14))).Any()).Count();
                pairs.Add(pair);
            }
            return pairs;
        }
    }
}
