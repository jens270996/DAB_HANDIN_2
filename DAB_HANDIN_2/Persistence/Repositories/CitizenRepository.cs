﻿using Covid19_Tracking.Domain;
using Covid19_Tracking.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
//using Queries.Core.Domain;
//using Queries.Core.Repositories;

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

            List < DateTime >  infectedDates = new List<DateTime>();

            foreach(var date in infected.TestDates.Where(t => t.Result == true).Select(t => t.Date))
            {
                var d= date.Date;
                for (int i = 0; i < 4; i++)
                {
                    infectedDates.Add(d.AddDays(-i));
                }
            }

            var infectedLocations = infected.CitizenLocations.Where(c => infectedDates.Contains(c.Date.Date));

            List<Citizen> InfectedCitizens = new List<Citizen>();
             foreach(var c in CovidContext.Citizens.ToList())
                {
                var joinedlocations=c.CitizenLocations.Join(infectedLocations, i => i.Location, i => i.Location, (infector, infected) =>
                         new { infectorDate = infector.Date, inefectedDate = infected.Date });

                foreach(var loc in joinedlocations)
                {
                    if (loc.inefectedDate.Date == loc.infectorDate)
                        InfectedCitizens.Add(c);
                }
                

             }
            return InfectedCitizens;

        }
        public IEnumerable<Citizen> GetInfectedCitizensInNation(Nation nation)
        {
            var citizensInNation = CovidContext.Citizens
                .Where(c => c.Municipality.Nation == nation);

                return citizensInNation.Include(c => c).Where(c => c.TestDates.Where(t => (t.Result == true) && (t.Date - DateTime.Today < TimeSpan.FromDays(14))).Any());

        }
        public IEnumerable<Citizen> GetInfectedCitizens()
        {

            var citizens=CovidContext.Citizens.Include(c => c.TestDates).ToList();
            citizens=citizens.Where(c => c.TestDates
                .Where(t => (t.Result == true)).Where(t=>t.Date - DateTime.Today < TimeSpan.FromDays(14)).Any()).ToList();

            return citizens;

        }

        public long InfectedInterval(int minAge,int maxAge,string gender)
        {
            if (gender == "all")
            {
                return GetInfectedCitizens().ToList().Where(c => c.Age <= maxAge ).Where(c=>c.Age >= minAge).Count();
            }
            else
            {
                return GetInfectedCitizens().ToList().Where(c => c.Age <= maxAge).Where(c => c.Age >= minAge).Where(c=>c.Sex==gender).Count();
            }
        }

        public CovidContext CovidContext
        {
            get { return Context as CovidContext; }
        }
    }
}
