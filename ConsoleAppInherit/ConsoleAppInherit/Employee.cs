using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInherit
{
    internal class Employee : Person 
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        internal override string Id
        {
            get { return this.id; }
            set { this.id = "p-" + value + "-E"; }
        }
        /*internal Employee(int id, string name, string bloodGroup, double salary, MyDate dateOfBirth) : base(id, name, bloodGroup, dateOfBirth)
        {
           
            this.Salary = salary;
            

        }
        internal void ShowEmployeeInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary : {0}\n", this.salary);
        }*/

        //internal Employee(int id,string name, string bloodGroup, double salary, MyDate dateOfBirth) : base(id,name, bloodGroup, dateOfBirth)
        internal Employee(string name, string bloodGroup, double salary, MyDate dateOfBirth) : base(name, bloodGroup, dateOfBirth)
        {

            this.Salary = salary;


        }


        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary : {0}\n", this.salary);
        }

    }
}
