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
        
        
        public void SetQuotient()
        {
            Quotient = Votes / (Seats + 1);
        }

        public void InitialiseSeats(int initialValue)
        {
            Seats = initialValue;
        }



    }
}
