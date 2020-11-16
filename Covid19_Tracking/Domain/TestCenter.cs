using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class TestCenter
    {
        public TestCenter()
        {
            TestDates = new HashSet<TestDate>();
        }

        public TestCenter(int hours1)
        {
            hours = hours1;
            TestDates = new HashSet<TestDate>();
        }
        public int hours { get; set; }
        public virtual TestCenterManagement TestCenterManagement { get; set; }
        public int TestID { get; set; }
        public virtual Municipality Municipality { get; set; }
        public virtual ICollection<TestDate> TestDates { get; set; } 
    }
}
