using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        //member variables
        private ISweepStakesManager _manager;

        //constructor
        public MarketingFirm(ISweepStakesManager manager)
        {
            this._manager = manager;
        }

        //member methods
        public void CreateSweepstakes()
        {
            Console.WriteLine("What would you like to name the Sweepstakes?");
            string sweepstakesName = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesName);
            _manager.InsertSweepstakes(sweepstakes);           
        }

       
    }
}
