using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRealApp.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string firstName, string lastName, string email, DateTime birthday, double hourlyRate) : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
    }
}
