using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Domain
{
    public class TestCenterManagement
    {

       

        public TestCenterManagement(int id, string email1, int phone)
        {
            TestCenterId = id;
            PhoneNumber = phone;
            Email = email1;
           

        }


        public int TestCenterManagementId { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TestCenterId { get; set; }
        public virtual TestCenter TestCenter { get; set; }
        
    }
}
