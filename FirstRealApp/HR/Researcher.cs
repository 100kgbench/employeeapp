using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRealApp.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email, DateTime birthday, double hourlyRate) : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
        private int numberOfPiesInvented;
        public int NumberOfPiesInvented
        {
            get { return numberOfPiesInvented; }
            private set { NumberOfPiesInvented = value; }

        }
        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            if (new Random().Next(100) > 50)
            {
                numberOfPiesInvented++;
                Console.WriteLine($"{FirstName} {LastName} has invented a new pie taste! Total number of pie tastes invented is {numberOfPiesInvented}");

            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is still working on inventing new pie tastes");
            }
        }
    }
}
