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
        public string company;
        public int wagePerHour;
        public int noOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public Employee(string company, int wagePerHour, int noOfWorkingDays,
            int maxHourInMonth)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHoursPerMonth = maxHourInMonth;
            
        }
        public void Attendance()
        { 
        int empHrs=0,totalEmpHours = 0, totalWorkingDays = 0;
        
            while (totalEmpHours <= this.maxHoursPerMonth && totalWorkingDays < this.noOfWorkingDays )
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
            totalEmpWage = totalEmpHours*this.wagePerHour;
            Console.WriteLine("Total Emp wage for company: " + company + " is " + +totalEmpWage);
    } 
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company+ " is : "+this.totalEmpWage;
        }
    
    }
}
