using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            
        }
        public string GetSweepstakesType()
        {
            Console.WriteLine("Which way would you like to manage your sweepstakes?  Type 'Queue' or 'Stack'.");
            string input = Console.ReadLine();
            return input;
        }
    }
}
