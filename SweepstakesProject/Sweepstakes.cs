using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //member variables
        private string name;
        private Dictionary<int, Contestant> contestants;
        //private List<Contestant> contestants1;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            
            contestants.Add(contestants.Count + 1, contestant);
           
        }
        public Contestant PickWinner()
        {          
            Random random = new Random();
            int winnerToPick = random.Next(contestants.Count);
            Contestant winner = contestants[winnerToPick];
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}, Last Name: {contestant.lastName}, Email: {contestant.emailAddress}");                                   
        }

    }
}
