using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Application
{
    public class CompanyDto
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string MailAddress { get; set; }
        public int PhoneNo { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }
    }

    public class CompanyInput
    {
           
        public string CompanyName { get; set; }
        public string MailAddress { get; set; }
        public int PhoneNo { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }
    }
}
