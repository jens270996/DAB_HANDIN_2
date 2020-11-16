using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Queries.Core.Domain;
using Queries.Core.Repositories;

using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Covid19_Tracking.Persistence.Repositories
{
    public class CitizenRepository : Repository<Citizen>, ICitizenRepository
    {
        public CitizenRepository(CovidContext context) : base(context)
        {
        }
        public IEnumerable<Citizen> GetPossibleInfectedCitizens(Citizen infected)
        {

            var spreadingDays = infected.TestDates.Where(t => t.Result == true)
            var infectedLocations = infected.CitizenLocations;
            
           infectedLocations.Where(c=>c.Date-

            CovidContext.Citizens
                .Include(c=>c)
                .Where(c=>c.Date))
        }
        public IEnumerable<Citizen> GetInfectedCitizensInNation(Nation nation)
        {
            var citizensInNation = CovidContext.Citizens.Include(c => c)
                .Where(c => c.Municipality.Nation == nation);

                return citizensInNation.Include(c => c).Where(c => c.TestDates.Where(t => (t.Result == true) && (t.Date - DateTime.Today < TimeSpan.FromDays(14))).Any());

        }
        public IEnumerable<Citizen> GetInfectedCitizens()
        {
            
            return CovidContext.Citizens.Include(c => c).Where(c => c.TestDates.Where(t => (t.Result == true) && (t.Date - DateTime.Today < TimeSpan.FromDays(14))).Any());

        }

        public CovidContext CovidContext
        {
            get { return Context as CovidContext; }
        }
    }
}
