using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepSteaks
{
    class sweepstakesStackManager : ISweepstakesManager
    {
        private Stack<Sweepstakes> Stack;

        public sweepstakesStackManager()
        {
            Stack = new Stack<Sweepstakes>();
        }
    public void InsertSweepstakes(Sweepstakes sweepstakes)

    {
            Stack.Push(sweepstakes);
    }
        public Sweepstakes GetSweepstakes()
        {
            return Stack.Pop();
        }
}
}
