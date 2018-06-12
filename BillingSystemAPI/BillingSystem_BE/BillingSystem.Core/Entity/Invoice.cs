using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingSystem.Core
{
    [Table("Invoice")]
    public class Invoice : BaseEntity
    {
        public int InvoiceID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Company CompanyID { get; set; }

        public int Total { get; set; }

     
    }
}
