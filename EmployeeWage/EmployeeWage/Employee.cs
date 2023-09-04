using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int wagePerHour = 20, isPresent = 0, isFullTime = 1;
        int fullDayHour = 0;


        public void Attendance()
        {
            Random random = new Random();
            int empCheck=random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is Present.");
                fullDayHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
                fullDayHour = 0;
            }
            int empWage = fullDayHour * wagePerHour;
            Console.WriteLine("Daily wage is: "+empWage);

        }

    }
}
