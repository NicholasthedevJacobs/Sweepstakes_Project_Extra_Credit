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
        

        //constructor
        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            emailAddress = UserInterface.GetEmail();
            
            registrationNumber = 0;
        }

        //member methods
        public void Update(Contestant winner)
        {
            Console.WriteLine($"Congratulations to {winner.firstName} {winner.lastName} for winning the sweepstakes!  Sorry to everyone else who participated.  Better luck next time.");
            
        }


    }
}
