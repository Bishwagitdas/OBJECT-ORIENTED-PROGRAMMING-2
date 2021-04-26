using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInherit
{

    internal class Student : Person
    {
        private double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set { this.cgpa = value; }
        }

        internal override string Id
        {
            get { return this.id; }
            set { this.id = "p-" + value + "-S"; }
        }

        /* internal Student(int id, string name, string bloodGroup,double cgpa,MyDate dateOfBirth) : base(id,name,bloodGroup,dateOfBirth)
         {
             this.Id = id;
             this.Name = name;
             this.BloodGroup = bloodGroup;
             this.Cgpa = cgpa;
             this.DateOfBirth = dateOfBirth;

         }
         internal void ShowStudentInfo()
         {
             this.ShowPersonInfo();
             Console.WriteLine("Cgpa : {0}\n", this.cgpa);
         }
        */

        //internal Student(int id,string name, string bloodGroup, double cgpa, MyDate dateOfBirth) : base(id,name, bloodGroup, dateOfBirth)
        internal Student(string name, string bloodGroup, double cgpa, MyDate dateOfBirth) : base(name, bloodGroup, dateOfBirth)
        {
            
            this.Cgpa = cgpa;

        }
        internal  override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Cgpa : {0}\n", this.cgpa);
        }


    }


}
