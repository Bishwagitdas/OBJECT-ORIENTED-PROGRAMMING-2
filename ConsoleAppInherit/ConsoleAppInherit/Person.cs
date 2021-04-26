using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInherit
{

    internal struct MyDate
    {
        private byte day;
        private string month;
        private ushort year;
        internal MyDate(byte day, string month, ushort year)
        {
            if(day >=1 && day <=31)
            {
                this.day = day;
                this.month = month;
                this.year = year;

            }
            else 
            {
                this.day = 12;
                this.month = "Feb";
                this.year = 1998;

            }
        }
        internal void ShowDate()
        {
            Console.WriteLine("Date Of Birth:{0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    internal class Person
    {
        private static int serialNo = 0;
       /* private string id;*/
        protected string id;
        private string name;
        private string bloodGroup;
        private MyDate dateOfBirth;


        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "p-" + value + "_S"; }
        }

        /*internal int Id
        {
            get { return this.id; }
            set { this.id = "p-" + value; }
        }*/



        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }
        internal MyDate DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        /*internal Person(int id,string name, string bloodGroup, MyDate dateOfBirth)
        {
            this.Id = id;
            this.Name = name;
            this.BloodGroup = bloodGroup;
            this.DateOfBirth = dateOfBirth;

        }*/

        internal Person(string name,string bloodGroup, MyDate dateOfBirth)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.BloodGroup = bloodGroup;
            this.DateOfBirth = dateOfBirth;

        }

        /*internal void ShowPersonInfo()
        {
            Console.WriteLine("Information");
            Console.WriteLine("Id: {0}",this.Id);
            Console.WriteLine("Name: {0}",this.name);
            Console.WriteLine("BloodGroup: {0}",this.bloodGroup);
            this.DateOfBirth.ShowDate();


        }
        */

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Information");
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("BloodGroup: {0}", this.bloodGroup);
            this.DateOfBirth.ShowDate();


        }



    }
}
