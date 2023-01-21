using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRealApp.HR
{
    internal interface IEmployee
    {
        double RecieveWage(bool resetHours = true);
        void GiveBonus();
        
        void PerformWork(int numberOfHours);
        void DisplayEmployeeDetails();
        void GiveCompliment();
        
    }
}
