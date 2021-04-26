using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTask
{
    internal class Laptop : Product
    {
       

        private double quantity;
        internal double Quantity
        {
        
   
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    
        

        

        internal Laptop(int id,double quantity, double price, string manufacturerName, MyDate productionDate) : base(id, price, manufacturerName, productionDate)
        {

            this.quantity = quantity;


        }
        internal void ShowProductInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Quantity : {0}\n", this.quantity);
        }

    }
}
