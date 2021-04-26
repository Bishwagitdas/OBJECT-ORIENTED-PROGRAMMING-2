using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduct
{ 
    struct Date
    {
        public byte day;
        public byte month;
        public ushort year;

        public Date(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowManufactureDate()
        {
            Console.WriteLine("Product Info:");
            Console.WriteLine("Day NO:{0}",this.day);
            Console.WriteLine("Month No:{0}",this.month);
            Console.WriteLine("Year No:{0}",this.year);

        }
    }
    class Product
    {
        private ushort id;
        private string name;
        private Date manufactureDate;
        private uint price;


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

        public Date GetManufactureDate()
        {
            return this.manufactureDate;
        }

        public void SetManufactureDate(Date manufactureDate)
        {
            
                this.manufactureDate = manufactureDate;

            
        }

        public uint GetPrice()
        {
            return this.price;
        }

        public void SetPrice(uint price)
        {
            
                this.price = price;
           
        }

        public Product(ushort id,string name,Date manufactureDate,uint price)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetManufactureDate(manufactureDate);
            this.SetPrice(price);

        }

        public void ShowProductInfo()
        {
            Console.WriteLine("Product Id:{0}", this.GetId());
            Console.WriteLine("Product Name:{0}", this.GetName());
            Console.WriteLine("Product Manufacture Date:{0}", this.GetManufactureDate());
            Console.WriteLine("Product Price:{0}", this.GetPrice());
            

        }

    }
}
