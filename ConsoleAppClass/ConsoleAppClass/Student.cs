using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    struct OurAddress
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string dirstict;

        public OurAddress(byte houseNo, byte roadNo, ushort postalCode, tring dirstict,)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.dirstict = dirstict;
        }
        public void ShowAddress()
        {
            Console.WriteLine("Address Info");
            Console.WriteLine("House NO: {0}, this.houseNo");
            Console.WriteLine("Road No: {0}, this.roadNo");
            Console.WriteLine("Postal Code: {0}, this.postalCode");
            Console.WriteLine("Dirstict: {0}, this.dirstrict");


        }

    }

    class Student
    {
        private ushort id;
        private string name;
        private double cgpa;
        private string bloodGroup;
        private OurAddress address;


        public ushort GetId()
        {
            return this.id;
        }
        public void SetId(ushort id)
        {
            this.id = id;

        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;

        }

        public double GetCgpa()
        { 
            return this.cgpa;  
        }
        public void SetCgpa(double cgpa)
        {
            if (cgpa >= 0.0 && cgpa <= 4.0)
                this.cgpa = cgpa;
            else
            {
                this.cgpa = -1;
            }

        }

        public string GetBloodGroup()
        {
            return this.bloodGroup;
        }
        public void SetBloodGroup(string bloodGroup)
        {
            if(bloodGroup=="A+"|| bloodGroup == "O+" || bloodGroup == "B+" || bloodGroup == "AB+" || bloodGroup == "A-" || bloodGroup == "O-" || bloodGroup == "B-" || bloodGroup == "AB-" ||)

            this.bloodGroup = bloodGroup;

            else
            {
                this.bloodGroup = "Invalid";
            }

        }

        public OurAddress GetAddress()
        {
            return this.address;
        }

        public void SetAddress(OurAddress address)
        {
            this.address = address;
        }



        public Student()
        {

        }

        public Student(ushort id, string name, double cgpa, string bloodGroup)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetCgpa(cgpa);
            this.SetBloodGroup(bloodGroup);
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("Student's ID: {0}", this.GetId());
            Console.WriteLine("Student's Name: {0}", this.GetName());
            Console.WriteLine("Student's CGPA: {0}", this.GetCgpa());
            Console.WriteLine("Student's Blood Group: {0}\n", this.GetBloodGroup());
            this.address.ShowAddress();


        }

    }
}
