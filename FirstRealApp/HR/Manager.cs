using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRealApp.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthday, double hourlyRate) : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
        public void AttendManagerMeetings()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"{FirstName} {LastName} is now attending long manager meeting ");
        }
        public override void GiveBonus()
        {
            if ( NumberOfHoursWorked > 5 ) 
            {
                Console.WriteLine($"Manager {FirstName} {LastName} has recieved bonus of 500$");

            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} has recieved bonus of 250$");
            }
        }
    }
}
