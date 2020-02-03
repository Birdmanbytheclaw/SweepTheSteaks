using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepSteaks
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> Queue;

        public SweepstakesQueueManager()
        {
            Queue = new Queue<Sweepstakes>();
        }
        
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return Queue.Dequeue();
        }
  
    }
}
