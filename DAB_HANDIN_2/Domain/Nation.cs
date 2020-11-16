using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class Nation
    {
        public Nation()
        {
            Municipalities = new HashSet<Municipality>();
        }
        public Nation(string Name1)
        {
            Name = Name1;
            Municipalities = new HashSet<Municipality>();
        }
        public string Name { get; set; }

        public virtual ICollection<Municipality>Municipalities { get; set; }
    }
}
