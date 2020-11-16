using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class TestCenter
    {
        public int TestCenterId { get; set; }

        public TestCenter()
        {
            TestDates = new HashSet<TestDate>();
        }

        public TestCenter(int hours1, int hours2,string name)
        {
            
            OpenHour = hours1;
            CloseHour = hours2;
            TestDates = new HashSet<TestDate>();
            CenterName = name;
        }

        public string CenterName { get; set; }
        public int OpenHour { get; set; }
        public int CloseHour { get; set; }
        public virtual TestCenterManagement TestCenterManagement { get; set; }
       
        public virtual Municipality Municipality { get; set; }
        public virtual ICollection<TestDate> TestDates { get; set; } 
    }
}
