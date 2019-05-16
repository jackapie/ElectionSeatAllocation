using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectionSeatAllocation
{
    class Program
    {
        static void Main(string[] args)
        {
            var electionData = new ElectionData();

            var standingParties = electionData.StandingParties;

            var seatAllocator = new SeatAllocator(standingParties);

            for (int i = 0; i < electionData.NumberSeatsToBeAllocated; i++)
            {
                seatAllocator.AllocateSeat();
            }

            standingParties = standingParties.OrderByDescending(e => e.Seats).ToList();

            Console.WriteLine();
            Console.WriteLine("Results");

            foreach (var party in standingParties)
            {
                Console.WriteLine($"{party.Name} {party.Seats} seats");
            }
            Console.ReadLine();
        }
    }
}
