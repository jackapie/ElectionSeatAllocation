using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectionSeatAllocation
{
    class Program
    {
        static int NumberSeatsToBeAllocated;
        
        static int NumberPartiesStanding;

        static List<StandingParty> StandingParties;

        static void RetrieveNOfSeats()
        {
            Console.WriteLine($"Enter number of seats to be allocated: ");
            var nOfSeats = Console.ReadLine();
            try
            {
                NumberSeatsToBeAllocated = int.Parse(nOfSeats);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Please use only digits 0-9");
                RetrieveNOfSeats();
            }
        }

        static void SetPartyData()
        {
            StandingParties = new List<StandingParty>();

            RetrieveNOfParties();

            for (int i = 0; i < NumberPartiesStanding; i++)
            {
                var party = new StandingParty();
                Console.WriteLine();
                RetrieveName(party);
                RetrieveNOfVotes(party);
                StandingParties.Add(party);
            }
        }

        static void RetrieveNOfParties()
        {
            Console.WriteLine($"Enter number of parties standing: ");
            var nOfParties = Console.ReadLine();
            try
            {
                NumberPartiesStanding = int.Parse(nOfParties);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Please use only digits 0-9");
                RetrieveNOfParties();
            }
        }

        private static void RetrieveNOfVotes(StandingParty party)
        {
            Console.WriteLine($"Enter number of votes for {party.Name}: ");
            var voteEntry = Console.ReadLine();
            try
            {
                party.Votes = int.Parse(voteEntry);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Please use only digits 0-9");
                RetrieveNOfVotes(party);
            }
        }

        private static void RetrieveName(StandingParty party)
        {
            Console.WriteLine("Enter party name: ");
            party.Name = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            RetrieveNOfSeats();
            SetPartyData();
            var seatAllocator = new SeatAllocator(StandingParties);

            for (int i = 0; i < NumberSeatsToBeAllocated; i++)
            {
                seatAllocator.AllocateSeat();
            }

            StandingParties = StandingParties.OrderByDescending(e => e.Seats).ToList();

            Console.WriteLine();
            Console.WriteLine("Results");

            foreach (var party in StandingParties)
            {
                Console.WriteLine($"{party.Name} {party.Seats} seats");
            }
            Console.ReadLine();
        }
    }
}
