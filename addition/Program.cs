using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter 1st no");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd no");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Answer=" + c);
            Console.WriteLine();


        }
    }
}
