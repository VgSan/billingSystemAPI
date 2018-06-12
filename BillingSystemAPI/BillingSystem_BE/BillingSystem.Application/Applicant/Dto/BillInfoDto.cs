using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Application
{
    public class BillInfoDto
    {
        public int BillNo { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public string BillDate { get; set; }
        public string Bowser_Noplate { get; set; }
        public int BillTotal { get; set; }
        public string EmployeeName { get; set; }
        public int Quantity { get; set; }
        public int BowserId { get; set; }

        public int EmployeeId { get; set; }

    }

    public class BillInfoInput
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BowserId { get; set; }

        public int BillNo { get; set; }
        public int EmployeeId { get; set; }
   
        public string BillDate { get; set; }
  
        public int BillTotal { get; set; }
     
        public int Quantity { get; set; }
    }
}
