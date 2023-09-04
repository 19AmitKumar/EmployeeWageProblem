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
        const int wagePerHour = 20, isPresent = 0, isPartTime = 1, isFullTime = 2;
        const int noOfWorkingDays = 2,maxHourInMonth=10;
        int fullDayHour = 0,totalEmpHours=0, totalEmpWage = 0,totalWorkingDays=0;


        public void Attendance()
        {
            while (totalEmpHours <= maxHourInMonth && totalWorkingDays < noOfWorkingDays )
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                
                switch (empCheck)
                {
                    case isFullTime:
                        Console.WriteLine("Employee is Present.");
                        fullDayHour = 8;
                        break;
                    case isPartTime:
                        Console.WriteLine("Employee is Present.");
                        fullDayHour = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent.");
                        fullDayHour = 0;
                        break;
                }
                totalEmpHours += fullDayHour;
                Console.WriteLine("Days: "+totalWorkingDays+"Emp Hrs: "+fullDayHour);
            }
            totalEmpWage += fullDayHour;
            Console.WriteLine("Total Emp wage: "+totalEmpWage);

    } 
    
    }
}
