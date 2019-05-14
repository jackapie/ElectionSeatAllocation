using System;
using Xunit;
using ElectionSeatAllocation;

namespace ElectionSeatAllocationTests
{
    public class StandingPartyTests
    {
        [Fact]
        public void SetQuotientVotes0Seats0()
        {
            //Arrange
            var party = new StandingParty();
            party.Votes = 0;
            var expected = 0;

            //Act
            party.SetQuotient();
            var actual = party.Quotient;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
