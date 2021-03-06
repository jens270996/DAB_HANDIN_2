﻿using Covid19_Tracking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Repositories
{
    public interface ICitizenRepository:IRepository<Citizen>
    {
        public IEnumerable<Citizen> GetPossibleInfectedCitizens(Citizen infected);
        public IEnumerable<Citizen> GetInfectedCitizens();
        public long InfectedInterval(int minAge, int maxAge, string gender);
    }
}
