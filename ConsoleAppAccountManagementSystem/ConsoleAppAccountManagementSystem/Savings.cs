using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccountManagementSystem
{
    internal class Savings : Account 
    {
        

        internal override string Id
        {
            get { return this.id; }
            set { this.id = "AS-" + value; }
        }

        
        internal Savings(string name, double balance, OurDate openingDate, OurAddress address) : base(name,balance,openingDate, address)
        {
            

        }
        internal override bool Withdraw(double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 2000)
                {
                    base.Withdraw(amount);
                    Console.WriteLine("Withdraw Completed", amount);
                    return true;
                }
                else
                {
                    Console.WriteLine("user cannot withdraw more than 2000 taka at a time");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("no blance in avabilei Balance in user Account!!!");
                return false;
            }
        }


        internal override void ShowInfo()
        {
            base.ShowInfo();
           
        }
    }
}
