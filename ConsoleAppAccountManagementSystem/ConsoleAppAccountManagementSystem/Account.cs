using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccountManagementSystem
{
    internal struct OurDate
    {
        private byte day;
        private string month;
        private ushort year;

        internal OurDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
                this.month = month;
                this.year = year;

            }
            else
            {
                this.day = 12;
                this.month = "January";
                this.year = 2020;

            }
        }
        internal void ShowDate()
        {
            Console.WriteLine("OpeningDate:{0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    internal struct OurAddress
    {
        private byte apartmentNo;
        private byte roadNo;
        private string district;
        private string country;

        internal OurAddress(byte apartmentNo, byte roadNo,string district, string country)
        {
            this.apartmentNo = apartmentNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;

        }
        internal void ShowAddress()
        {
            Console.WriteLine("ApartmentNo: {0}", this.apartmentNo);
            Console.WriteLine("RoadNo: {0}", this.roadNo);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Country: {0}", this.country);
        }

    }

    internal class Account
    {
        private string name;
        private static int serialNo = 0;
        protected string id;
        private double balance;
        private OurDate openingDate;
        private OurAddress address;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "A-" + value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }

        internal  OurDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }

        internal OurAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal Account(string name, double balance, OurDate openingDate, OurAddress address)
        {
            this.Name = name;
            this.Id = (++serialNo).ToString();
            this.Balance = balance;
            this.OpeningDate =openingDate;
            this.Address = address;

        }

        internal virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                if (amount > 500)
                {
                    this.Balance = this.balance+amount;

                }
                else
                {
                    Console.WriteLine("User amount is less than 500 Amount");

                }
               
            }
            else
            {
                Console.WriteLine("Please Deposit a valid Amount");
            }
        }

        internal virtual bool Withdraw(double amount)
        {
            if (amount > 0)
                
            {
                this.Balance = this.balance - amount;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
                return false;
            }
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Information");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Balance: {0}", this.Balance);
            Console.WriteLine("OpeningDate: {0}", this.OpeningDate);
            Console.WriteLine("Address: {0}", this.Address);
            this.OpeningDate.ShowDate();
            this.Address.ShowAddress();


        }





    }


}
    

