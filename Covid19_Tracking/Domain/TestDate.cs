using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    class TestDate
    {
        public bool Result { set; get; }
        public DateTime Date { set; get; }
        public string Status { set; get; }
        public int SSN { set; get; }
        public int TestID { get; set; }

        public virtual TestCenter TestCenter { get; set; }
        public virtual Citizen Citizen { get; set; }
    }
}
