using System;
using Xunit;
using ElectionSeatAllocation;
using ElectionSeatAllocationTests.Fakes;
using System.Collections.Generic;

namespace ElectionSeatAllocationTests
{
    public class AllocateSeatCalculatorTests
    {
        [Fact]
        public void CalculateSeatWonTest()
        {
            //Arrange
            var mockParty = new FakeStandingParty();
            mockParty.Votes = 0;
            
            var partyList = new List<StandingParty>();
            partyList.Add(mockParty);

            var calculator = new AllocateSeatCalculator(partyList);

            //Act
            var actual = calculator.CalculateSeatWon();

            //Assert
            Assert.Equal(mockParty, actual);
        }
    }
}
