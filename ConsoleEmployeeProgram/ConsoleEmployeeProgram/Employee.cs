using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmployeeProgram
{

    struct OurAddress
    {
        private byte houseNo;
        private string streetName;
        private string upazilaName;


        public OurAddress(byte houseNo, string streetName, string upazilaName)
        {

            this.houseNo = houseNo;
            this.streetName = streetName;
            this.upazilaName = upazilaName;

        }

        public void ShowAddress()
        {
            Console.WriteLine("Address Info");
            Console.WriteLine("House no: {0}", this.houseNo);
            Console.WriteLine("StreetName: {0}", this.streetName);
            Console.WriteLine("UpazilaName: {0}", this.upazilaName);

        }
    }




    class Employee
    {
        private ushort id;
        private string name;
        private int monthlySalary;
        private string joiningDate;
        private OurAddress address;


    public ushort Id
    {
        get { return this.id;}
        set { this.id = value; }
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Monthlysalary
    {
        get { return this.monthlySalary; }
        set { this.monthlySalary = value; }
    }


    public string Joiningdate
    {
        get { return this.joiningDate; }
        set { this.joiningDate = value; }
    }

    public MyAddress Address
    {
        get { return this.address; }
        set { this.address = value; }
    }

        public Employee()
        {
        }



        public Employee(ushort id, string name, int monthlySalary, string joiningDate, OurAddress address)
        {
            this.Id = id;
            this.Name = name; 
            this.Monthlysalary = monthlySalary;
            this.joiningDate = joiningDate; 
            this.Address = address; 
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("Employee's ID: {0}", this.Id); 
            Console.WriteLine("Employee's Name: {0}", this.Name); 
            Console.WriteLine("MonthlySalary: {0}", this.monthlySalary); 
            Console.WriteLine("joiningDate: {0}", this.joiningDate); 
            this.Address.ShowAddress();
        }
    }
}







    }

