using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleEmployeeProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employeeOne = new Employee();
            employeeOne.Id = 100;
            employeeOne.Name = "abc";
            employeeOne.MonthlySalary = 1000;
            employeeOne.joiningDate = "10/5/2020"; 
            
        }
    }
}
