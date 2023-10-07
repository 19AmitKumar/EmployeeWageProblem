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
        public const int  isPresent = 0, isPartTime = 1, isFullTime = 2;
        


        public static int Attendance(string company, int wagePerHour,int noOfWorkingDays,
            int maxHourInMonth)
        { 
        int empHrs=0,totalEmpHours = 0, totalEmpWage, totalWorkingDays = 0;
        
            while (totalEmpHours <= maxHourInMonth && totalWorkingDays < noOfWorkingDays )
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                
                switch (empCheck)
                {
                    case isFullTime:
                        Console.WriteLine("Employee is Present.");
                        empHrs = 8;
                        break;
                    case isPartTime:
                        Console.WriteLine("Employee is Present.");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent.");
                        empHrs = 0;
                        break;
                }
                totalEmpHours +=empHrs;
                Console.WriteLine("Days:" + totalWorkingDays+" Emp Hrs: "+empHrs);
            }
            totalEmpWage = totalEmpHours*wagePerHour;
            Console.WriteLine("Total Emp wage for company: " + company + " is " + +totalEmpWage);
            return totalEmpWage;

    } 
    
    }
}
