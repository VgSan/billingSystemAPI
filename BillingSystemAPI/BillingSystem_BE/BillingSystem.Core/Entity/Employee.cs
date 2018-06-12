using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingSystem.Core
{
    [Table("Employee")]
    public class Employee : BaseEntity
    {
        public int EmployeeNIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string DrivingLisonNo { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public string EmployeeType { get; set; }
    }
}
