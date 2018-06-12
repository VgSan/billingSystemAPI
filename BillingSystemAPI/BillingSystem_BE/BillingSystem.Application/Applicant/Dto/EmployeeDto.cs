using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Application
{
    public class EmployeeDto
    {
        public int EmployeeNIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string DrivingLisonNo { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public string EmployeeType { get; set; }
    }

    public class EmployeeInput
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string DrivingLisonNo { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public string EmployeeType { get; set; }
    }
}
