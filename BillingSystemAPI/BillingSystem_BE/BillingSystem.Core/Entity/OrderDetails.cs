using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingSystem.Core
{
    [Table("OrderDetails")]
    public class OrderDetails : BaseEntity
    {
        public string OrderDetailsID { get; set; }
        public string OrderDate{ get; set; }

        public Company CopmanyName { get; set; }

        public Company CompanyID { get; set; }

        public bool OrderStatus { get; set; }
    }
}
