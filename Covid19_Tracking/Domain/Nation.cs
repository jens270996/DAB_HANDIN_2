using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    class Nation
    {
        public Nation()
        {
            Municipalities = new HashSet<Municipality>();
        }
        public int ID { get; set; }

        public virtual ICollection<Municipality>Municipalities { get; set; }
    }
}
