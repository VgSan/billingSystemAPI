using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Application
{
    public class InvoiceDto
    {

        public int InvoiceID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CompanyID { get; set; }

        public int Total { get; set; }
    }

    public class InvoicInput
    {

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CompanyID { get; set; }
        public int Total { get; set; }
    }
}