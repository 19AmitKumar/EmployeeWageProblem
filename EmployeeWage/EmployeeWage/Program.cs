using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee dMart=new Employee("DMart",20,2,10);
            Employee reliance=new Employee("Reliance",10,4,20);
            dMart.Attendance();
            Console.WriteLine(dMart.ToString());
            reliance.Attendance();
            Console.WriteLine(reliance.ToString());


            Console.ReadLine();
        }
        
    }
}
