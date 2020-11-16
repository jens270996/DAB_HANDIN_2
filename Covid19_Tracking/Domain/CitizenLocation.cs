using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class CitizenLocation
    {
        public int SSN { get; set; }
        public string Adresse { get; set; }
        public DateTime Date { get; set; }

        public virtual Location Location { get; set; }
        public virtual Citizen Citizen { get; set; }

    }
}
