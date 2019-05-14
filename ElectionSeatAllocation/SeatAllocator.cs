using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElectionSeatAllocation
{
    public class SeatAllocator
    {
        readonly List<StandingParty> standingParties;

        public SeatAllocator(List<StandingParty> parties)
        {
            this.standingParties = parties;
        }

        public StandingParty CalculateSeatWon()
        {
            foreach(var party in standingParties)
            {
                party.SetQuotient();
            }

            var winningParty = standingParties
                .OrderByDescending(e => e.Quotient)
                .First();

            return winningParty;
        }
    }
}
