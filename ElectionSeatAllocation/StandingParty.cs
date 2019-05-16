using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionSeatAllocation
{
    public class StandingParty
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public int Seats { get; set; }

        public StandingParty()
        {
            Seats = 0;
        }
        
        
        public decimal GetQuotient()
        {
            return Votes / (Seats + 1);
        }     

        
    }
}
