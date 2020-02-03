using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepSteaks
{
    public class MarketingFirm
    {
        private ISweepstakesManager _Manager;
    
        public MarketingFirm(ISweepstakesManager manager)
        {
            _Manager = manager;
        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(usetInterface.GetUserInputFor("What is this Sweepstakes Called? "));

            _Manager.InsertSweepstakes(sweepstakes);
        }
         public Contestant RunSweepstakes()
        {
            Sweepstakes sweepstakes = _Manager.GetSweepstakes();
            Contestant Winner;
            Int32.TryParse(usetInterface.GetUserInputFor("contestant maximum?"), out int ContestanrMaximum);
            int Contestant = 0;
            do
            {
                Contestant NewContestant;
                sweepstakes.RegisterContestant(NewContestant = new Contestant(usetInterface.GetUserInputFor("Enter First Name: "), usetInterface.GetUserInputFor("Enter Last Name: "), usetInterface.GetUserInputFor("Enter Email: ")));
                sweepstakes.PrintInfo(NewContestant);
                Contestant++;
            }
            while (ContestanrMaximum != Contestant);
            Winner = sweepstakes.PickWinner();
            sweepstakes.EmailContestantsForPrizeOrNot(Winner, sweepstakes);
            return Winner;
        }
    }
}
