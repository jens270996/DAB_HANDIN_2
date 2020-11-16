﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class Citizen
    {
        public Citizen()
        {
            TestDates = new HashSet<TestDate>();
            CitizenLocations = new HashSet<CitizenLocation>();
        }
        public int SSN {get; set;}
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public int ID { get; set; }
        public virtual Municipality Municipality { get; set; }

        public virtual ICollection<CitizenLocation> CitizenLocations { get; set; }
        public virtual ICollection<TestDate> TestDates { get; set; }
    }
}
