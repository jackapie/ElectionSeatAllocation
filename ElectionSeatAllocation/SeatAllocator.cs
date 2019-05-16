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

        private StandingParty CalculateSeatWon()
        {
           
            var winningParty = standingParties
                .OrderByDescending(e => e.GetQuotient())
                .First();

            return winningParty;
        }

        public void AllocateSeat()
        {
            var winningParty = CalculateSeatWon();
            winningParty.Seats += 1;
        }
    }
}
