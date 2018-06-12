using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace BillingSystem.Core
{
    [Table("BillInfo")]
    public class BillInfo : BaseEntity
    {
        
        public int   CompanyId { get; set; }

        public int EmployeeId { get; set; }
        public int BillNo { get; set; }
       
        public Company Company { get; set; }
        public string BillDate { get; set; }
        public Bowsers Bowser { get; set; }
        public int BowserId { get; set; }
        public int BillTotal { get; set; }
        public Employee Employee { get; set; }
        public int Quantity { get; set; }

        //public ICollection<Experience> Experiences { get; set; }
    }

}
