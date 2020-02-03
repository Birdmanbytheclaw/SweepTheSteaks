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
        Contestant contestant;
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

        }

      

}   }
