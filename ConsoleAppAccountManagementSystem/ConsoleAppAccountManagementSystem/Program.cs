using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[3];
            accounts[0] = new Savings("Apu", 4000, new OurDate(12,"January",2020), new OurAddress(2,10,"Naogaon","Bangladesh"));
            accounts[1] = new Current("Tapu", 3000, new OurDate(13, "January", 2020), new OurAddress(1,10,"Naogaon", "Bangladesh"));
            accounts[2] = new Loan("Tapu", 5000, new OurDate(14, "January", 2020), new OurAddress(4,12, "Naogaon", "Bangladesh"));

        }
    }
}
