using BethanysPieShopHRM.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstRealApp.HR
{
    internal class Employee:IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double hourlyRate;
        private double wage;
        
        
        private DateTime birtDay;
        public static double taxRate = 0.15;

        private Adress address;
        

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            protected set
            {
                numberOfHoursWorked = value;
            }
        }
        public double Wage
        {
            get
            {
                return wage;
            }
            private set { wage = value; }
        }
        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            private set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return birtDay;
            }
            private set { birtDay = value; }
        }
        public Adress Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }





        public Employee(string firstName, string lastName, string email, DateTime birthday, double hourlyRate, string street, string houseNumber, string city, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyRate = hourlyRate;
            Address = new Adress(street, houseNumber, city, zip);
            
        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, double hourlyRate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            BirthDay = birthday;
            this.hourlyRate = hourlyRate;
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s)!");
        }
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} has recieved generic bonus of 100$");
        }
        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 40)
            {
                bonus += 20;

            }
            else
            {
                bonus = 0;
            }


            return bonus;
        }
        public double RecieveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate;
            double taxAmount = wageBeforeTax * taxRate;
            double Wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"{FirstName} {LastName} has recieved a wage of {Wage} for {NumberOfHoursWorked} hours of work.");





            if (resetHours)
            {
                NumberOfHoursWorked = 0;

            }
            return Wage;
        }

        
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName} \nLast name: \t{LastName} \nEmail: \t{Email} \nBirthday: \t{BirthDay.ToShortDateString()}\n");

        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You´ve done a good job, {FirstName}");
        }
    }
}
