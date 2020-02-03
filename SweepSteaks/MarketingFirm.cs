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
            Contestant WinnerWinnerChickenParm;
            Int32.TryParse(usetInterface.GetUserInputFor("contestant maximum?"), out int ContestanrMaximum);
            int Contestant = 0;
            do
            {
                Contestant NewContestant;
                Sweepstakes.RegisterContestant(NewContestant = new Contestant(usetInterface.GetUserInputFor("Enter First Name: "), usetInterface.GetUserInputFor("Enter Last Name: "), usetInterface.GetUserInputFor("Enter Email: ")));
                Sweepstakes.PrintInfo(NewContestant);
                Contestant++;
            }
            while (ContestanrMaximum != Contestant);
            WinnerWinnerChickenParm = Sweepstakes.PrintWinner();
            sweepstakes.EmailAllContestants(WinnerWinnerChickenParm);
            return WinnerWinnerChickenParm;
        }
    }
}
