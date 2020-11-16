using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class Municipality
    {
        public Municipality()
        {
            Citizens = new HashSet<Citizen>();
            TestCenters = new HashSet<TestCenter>();
            Locations = new HashSet<Location>();
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public virtual Nation Nation { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set;}
        public virtual ICollection<TestCenter> TestCenters { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
