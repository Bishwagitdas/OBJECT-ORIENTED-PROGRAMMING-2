using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    internal class Parent
    {
        internal Parent(): this("bgd")
        {
            Console.WriteLine("Parent");
       }
        internal Parent(int y) : this()
        {
            Console.WriteLine("Parent " + y);
        }
        internal Parent(string y)
        {
            Console.WriteLine("Parent S " + y);
        }
        internal virtual void M1()
        {
            Console.WriteLine("Parent M1");

        }
        internal virtual void M2()
        {
            Console.WriteLine("Parent M2");

        }




    }
}
