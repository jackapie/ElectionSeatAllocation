using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionSeatAllocation
{
    public class ElectionData
    {
        public int NumberSeatsToBeAllocated;

        public int NumberPartiesStanding;

        public List<StandingParty> StandingParties;

        void RetrieveNumberOfSeats()
        {
            var instruction = $"Enter number of seats to be allocated: ";

            NumberSeatsToBeAllocated = GetInputNumeric(instruction);
        }

        private int GetInputNumeric(string instruction)
        {
            Console.WriteLine(instruction);
            var input = Console.ReadLine();
            try
            {
                return int.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry. Please use only digits 0-9");
                return GetInputNumeric(instruction);
            }
        }

        void RetrieveNumberOfParties()
        {
            var instruction = $"Enter number of parties standing: ";

            NumberPartiesStanding = GetInputNumeric(instruction);

        }

        void RetrieveName(StandingParty party)
        {
            Console.WriteLine("Enter party name: ");
            party.Name = Console.ReadLine();
        }

        void RetrieveNumberOfVotes(StandingParty party)
        {
            var instruction = $"Enter number of votes for {party.Name}: ";
            party.Votes = GetInputNumeric(instruction);

        }

        void SetPartyData()
        {
            RetrieveNumberOfSeats();

            StandingParties = new List<StandingParty>();

            RetrieveNumberOfParties();

            for (int i = 0; i < NumberPartiesStanding; i++)
            {
                var party = new StandingParty();
                Console.WriteLine();
                RetrieveName(party);
                RetrieveNumberOfVotes(party);
                StandingParties.Add(party);
            }
        }

        public ElectionData()
        {
            SetPartyData();
        }
    }
}
