using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingSystem.Core
{
        [Table("Bowsers")]
        public class Bowsers : BaseEntity
        {
            public string BowserNoPlate { get; set; }
            public int Capacity { get; set; }
            public string Model { get; set; }
           
            //public ICollection<Experience> Experiences { get; set; }
        }
    }

