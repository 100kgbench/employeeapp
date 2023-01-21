using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRealApp.HR
{
    internal class Developer : Employee
    {
        public Developer(string firstName, string lastName, string email, DateTime birthday, double hourlyRate) : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
        private string currentProject;
        public string CurrentProject
        {
            get { return currentProject; }
             set { currentProject = value; }
        }

    }
}
