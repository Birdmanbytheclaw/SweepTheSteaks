using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepSteaks
{
    public class Simulation
    {
        public void CreateMarketingFirmWithAManager()
        {
            ISweepstakesManager manager;
            switch (usetInterface.GetUserInputFor("What kind of Sweepstakes would you like to make.. Stack or Queue? ").ToLower())
            {
                case "Stack":
                    manager = new sweepstakesStackManager();
                    break;
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    throw new Exception("choose a valid option please ");
            }
            MarketingFirm firm = new MarketingFirm(manager);
            firm.CreateSweepstakes();
            firm.RunSweepstakes();
        }            
    }
}
