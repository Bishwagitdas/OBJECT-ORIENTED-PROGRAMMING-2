using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTask
{

    internal struct MyDate
    {
        private byte day;
        private string month;
        private ushort year;
        internal MyDate(byte day, string month, ushort year)
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
                this.month = "Feb";
                this.year = 2020;

            }
        }
        internal void ShowDate()
        {
            Console.WriteLine("Production Date:{0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    internal class Product
    {
        
        private int id;
        private double quantity;
        private double price;
        private string manufacturerName;
        private int expiryDate;
        private MyDate productionDate;

        internal int Id
       {
           get { return this.id; }
           set { this.id =value; }
       }

        internal double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        internal double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        internal string ManufacturerName
        {
            get { return this.manufacturerName; }
            set { this.manufacturerName = value; }
        }

        internal int ExpiryDate
        {
            get { return this.expiryDate; }
            set { this.expiryDate = value; }
        }

        internal MyDate ProductionDate
        {
            get { return this.productionDate; }
            set { this.productionDate = value; }
        }

        internal Product(int id, double quantity, double price, string manufacturerName, int expiryDate, MyDate productionDate)
        {
           this.Id = id;
           this.Quantity = quantity;
           this.price = price;
           this.ManufacturerName = manufacturerName;
            this.ExpiryDate = expiryDate;
            this.ProductionDate = productionDate;

        }

        internal void ShowProductInfo()
        {
            Console.WriteLine("Information");
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Quantity : {0}", this.Quantity);
            Console.WriteLine("price : {0}", this.price);
            Console.WriteLine("ExpiryDate: {0}", this.expiryDate);
            Console.WriteLine("ManufacturerName : {0}", this.ManufacturerName);
            this.ProductionDate.ShowDate();


        }






    }
}
