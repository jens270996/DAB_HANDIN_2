using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class Location
    {

        public Location()
        {
            CitizenLocations = new HashSet<CitizenLocation>();
        }

        public string Addresse { get; set; }



        public virtual Municipality Municipality { get; set; }

        public virtual ICollection<CitizenLocation> CitizenLocations { get; set; }
    }
}
