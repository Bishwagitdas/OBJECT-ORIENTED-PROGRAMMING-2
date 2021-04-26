using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccountManagementSystem
{
    internal class Loan : Account
    {
        internal override string Id
        {
            get { return this.id; }
            set { this.id = "AS-" + value; }
        }


        internal Loan(string name, double balance, OurDate openingDate, OurAddress address) : base(name, balance, openingDate, address)
        {


        }

        internal override bool Withdraw(double amount)
        {
            if (this.Balance > (amount + 50))
            {
                base.Withdraw(amount);
                Console.WriteLine("Withdraw Completed", amount);
                return true;
            }
            else
            {
                Console.WriteLine("sufficient Balance");
                return false;
            }
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();

        }
    }

}

