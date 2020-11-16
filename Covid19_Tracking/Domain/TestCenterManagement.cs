using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class TestCenterManagement
    {
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TestMangementID { get; set; }
        public virtual TestCenter TestCenter { get; set; }
        
    }
}
