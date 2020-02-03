using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepSteaks
{

    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

        }
       
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = (contestants.Count) + 1;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

         public void PrintInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.FirstName}" +
                $"Last Name: {contestant.LastName}" +
                $"Email: {contestant.EmailAddress}" +
                $"Registration Number: {contestant.RegistrationNumber}");
        }
        public Contestant PickWinner()
        {
            Random winner = new Random();
            Contestant newWinner;
            int RandomNumber = winner.Next(0, ((contestants.Count) + 1));
            newWinner = contestants[RandomNumber];
            return newWinner;
        }
         public void EmailContestantsForPrizeOrNot(Contestant Winner, Sweepstakes sweepstakes)
        {
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
            if (contestant.Value == Winner)
            {
                    contestant.Value.Notifacations($"You did it! you beat the odds. you won. woo.. hoo..{contestant.Value.FirstName}, {contestant.Value.LastName} You have won!!" +
                        $"You will Contacted about your prize shortly, probably");
        
            }
            else
            {
                    contestant.Value.Notifacations($"{contestant.Value.FirstName} , {contestant.Value.LastName} YOU lost. Try Again?");
            }


            }
            }
        }
    } 
}
