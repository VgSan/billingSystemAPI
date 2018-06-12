using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Application
{
    public class BowsersDto
    {
        
        public string BowserNoPlate { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
    }

    public class BowsersInput
    {
        public string BowserNoPlate { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
    }
}
