using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant : IObserver
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        public bool winner;
        

        //constructor
        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            emailAddress = UserInterface.GetEmail();
            winner = false;
            
            registrationNumber = 0;
        }

        //member methods
        public void Update(Contestant winner)
        {
            
            Console.WriteLine($"Congratulations to {winner.firstName} {winner.lastName} for winning the sweepstakes!  Sorry to everyone else who participated.  Better luck next time.");
            
        }
        public void UpdateTheWinner(Contestant winner)
        {
            Console.WriteLine("Contratulations, you have won the sweepstakes!");
        }


    }
}
