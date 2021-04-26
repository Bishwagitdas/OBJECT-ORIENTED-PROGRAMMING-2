using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    internal class Child : Parent
    {
        internal Child():this("hgd")
        {
            Console.WriteLine("Child");
        }
        internal Child(int q):this()
        {
            Console.WriteLine("Child "+ q);
        }
        internal Child(string q) : base(q)
        {
            Console.WriteLine("Child S " + q);
        }
        internal override void M1()
        {
            Console.WriteLine("Child M1");

        }
        internal override void M2()
        {
            Console.WriteLine("Child M2");

        }
    }
}
