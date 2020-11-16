using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class TestDate
    {
        public int TestDateID { get; set; }
        public bool Result { set; get; }
        public DateTime Date { set; get; }
        public string Status { set; get; }
        public int Citizen_ID { set; get; }
        public int TestCenterID { get; set; }

        public virtual TestCenter TestCenter { get; set; }
        public virtual Citizen Citizen { get; set; }
    }
}
