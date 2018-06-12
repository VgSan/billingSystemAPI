using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingSystem.Core
{
    [Table("Company")]
    public class Company : BaseEntity
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string MailAddress { get; set; }
        public int PhoneNo { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }

        //public ICollection<Experience> Experiences { get; set; }
    }
}
