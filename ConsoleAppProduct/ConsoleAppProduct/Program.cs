using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Date manufactureData1 = new Date(10, 8, 2020);

            Product ProductOne = new Product(10000, "BD", manufactureData1, 10);
            ProductOne.ShowProductInfo();
        }
    }
}
