using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class TestCenterManagement
    {

        public TestCenterManagement()
        { }

        public TestCenterManagement(int ID, string email1, int phone)
        {
            PhoneNumber = phone;
            Email = email1;
            TestMangementID = ID;

        }

        public int TestID { get; set; }

        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TestMangementID { get; set; }
        public virtual TestCenter TestCenter { get; set; }
        
    }
}
