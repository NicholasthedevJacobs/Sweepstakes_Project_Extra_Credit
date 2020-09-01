using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes : ISubject
    {
        //member variables
        private string name;
        private Dictionary<int, IObserver> contestants;
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
            contestants = new Dictionary<int, IObserver>();
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            
            contestants.Add(contestants.Count + 1, contestant);
           
        }
        public IObserver PickWinner()
        {          
            Random random = new Random();
            int winnerToPick = random.Next(contestants.Count);
            IObserver winner = contestants[winnerToPick];
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}, Last Name: {contestant.lastName}, Email: {contestant.emailAddress}");                                   
        }
        //public void Register(IObserver observer)
        //{
        //    contestants.Add(observer);
        //}
        public void NotifyObserver(IObserver observer)
        {
            foreach(KeyValuePair<int, IObserver> contestant in contestants)
            {
                observer.Update(contestants);
            }
            
        }
       

    }
}
