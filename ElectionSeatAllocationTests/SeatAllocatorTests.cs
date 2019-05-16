using System;
using Xunit;
using ElectionSeatAllocation;
using ElectionSeatAllocationTests.Fakes;
using System.Collections.Generic;

namespace ElectionSeatAllocationTests
{
    public class SeatAllocatorTests
    {
        //[Fact]
        //public void CalculateSeatWonTest()
        //{
        //    //Arrange
        //    var mockParty = new FakeStandingParty();
        //    mockParty.Votes = 0;
            
        //    var partyList = new List<StandingParty>();
        //    partyList.Add(mockParty);

        //    var calculator = new SeatAllocator(partyList);

        //    //Act
        //    var actual = calculator.CalculateSeatWon();

        //    //Assert
        //    Assert.Equal(mockParty, actual);
        //}

        [Fact]
        public void AllocateSeat1Party()
        {
            //Arrange
            var stubParty = new FakeStandingParty();
            stubParty.Votes = 0;

            var partyList = new List<StandingParty>();
            partyList.Add(stubParty);

            var allocator = new SeatAllocator(partyList);

            //Act
            allocator.AllocateSeat();
            var actual = stubParty.Seats;

            //Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void AllocateSeat2PartiesWinnersSeats()
        {
            //Arrange
            var stubPartyWinner = new FakeStandingParty();
            stubPartyWinner.Votes = 1;
            var stubPartyLoser = new FakeStandingParty();
            stubPartyLoser.Votes = 0;

            var partyList = new List<StandingParty>();
            partyList.Add(stubPartyWinner);
            partyList.Add(stubPartyLoser);

            var allocator = new SeatAllocator(partyList);

            //Act
            allocator.AllocateSeat();
            var actual = stubPartyWinner.Seats;

            //Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void AllocateSeat2PartiesLosersSeats()
        {
            //Arrange
            var stubPartyWinner = new FakeStandingParty();
            stubPartyWinner.Votes = 1;
            var stubPartyLoser = new FakeStandingParty();
            stubPartyLoser.Votes = 0;

            var partyList = new List<StandingParty>();
            partyList.Add(stubPartyWinner);
            partyList.Add(stubPartyLoser);

            var allocator = new SeatAllocator(partyList);

            //Act
            allocator.AllocateSeat();
            var actual = stubPartyLoser.Seats;

            //Assert
            Assert.Equal(0, actual);
        }

    }
}
