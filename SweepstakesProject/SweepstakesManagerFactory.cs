using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesManagerFactory
    {
        public ISweepStakesManager CreateSweepstakes(string sweepstakes)
        {
            ISweepStakesManager user = null;
            switch (sweepstakes)
            {
                case "Queue":
                    user = new SweepstakesQueueManager();
                    break;
                case "Stack":
                    user = new SweepstakesStackManager();
                    break;
                default:
                    Console.WriteLine("Please choose a valid option.");
                    CreateSweepstakes(sweepstakes);
                    break;
            }
            return user;
        }
    }
}
