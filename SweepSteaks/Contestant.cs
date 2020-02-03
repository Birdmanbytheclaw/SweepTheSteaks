using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepSteaks
{
    class Contestant
    {
       public string FirstName;
       public string LastName;
       public string EmailAddress;
       public int RegistrationNumber;

        public Contestant(string FirstName, string LastName, string EmailAddress)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
        }

        public void EntryCard(string output)
        {
            Console.WriteLine(output);
        }
      
    }
}
