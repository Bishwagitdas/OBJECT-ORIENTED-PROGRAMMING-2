using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTask
{
    internal class Cannedfood : Product
    {
        private int expiryDate;
        internal int ExpiryDate
        {
            get { return this.expiryDate; }
            set { this.expiryDate = value; }
        }

        internal Cannedfood(int id, double price, string manufacturerName, int expiryDate, MyDate productionDate) : base (id,price,manufacturerName, expiryDate, productionDate)
        {

            this.expiryDate = expiryDate;


        }
        internal void ShowProductInfo()
        {
            base.ShowProductInfo();
            Console.WriteLine("expiryDate : {0}\n", this.expiryDate);
        }
  


    }
}
