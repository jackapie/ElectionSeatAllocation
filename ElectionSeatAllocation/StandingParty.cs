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

        public decimal Quotient { get; private set; }

        public StandingParty()
        {
            Seats = 0;
        }
        
        
        public void SetQuotient()
        {
            Quotient = Votes / (Seats + 1);
        }     

        
    }
}
