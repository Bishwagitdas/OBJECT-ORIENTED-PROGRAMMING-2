using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent(20);
            // Child c = new Child(100);

            //Parent p1 = new Child();

            //Console.WriteLine();

            // p.M1();
            // c.M1();

            //Console.WriteLine();

            // p1.M1();
            //p1.M2();

            // Person P = new Person(100, "abcd", "O+", new MyDate(2, "May", 1998));
            //P.ShowPersonInfo();

            // Student s = new Student(200, "abdd", "O+", 3.25 ,new MyDate(22, "June", 1998));
            //s.ShowStudentInfo();

            //Employee e = new Employee(300, "abcc", "O+",30000, new MyDate(2, "May", 1999));
            // e.ShowEmployeeInfo();

            //Person p1 = new Student(200, "abdd", "O+", 3.25, new MyDate(22, "June", 1998));
           // Person p2 = new Employee(300, "abcc", "O+", 30000, new MyDate(2, "May", 1999));

           /// p1.ShowInfo();
           // p2.ShowInfo();

            Person[] p = new Person[3];

            //p[0] = new Student(200, "abdd", "O+", 3.25, new MyDate(22, "June", 1998));
            //p[1] = new Employee(300, "abcc", "O+", 30000, new MyDate(22, "June", 1998));
            //p[2] = new Student(400, "abba", "O+", 3.5, new MyDate(27, "June", 1998));


            //p[0] = new Student("abdd", "b+", 3.25, new MyDate(22, "May", 1998));
            //p[1] = new Employee("abcc", "O+", 30000, new MyDate(22, "June", 1997));
            //p[2] = new Student("abba", "ab+", 3.5, new MyDate(27, "Augest", 1996));



            //foreach(Person pp in p)
            // {
            //  pp.ShowInfo();
            // }

            //byte count = 0;
            //while(count<p.Length)
            // { 
            // p[count].ShowInfo();
            //count++;

            //}

            //XYZCorporation XYZ = new XYZCorporation();
            XYZCorporation.AddPerson(new Student("abdd", "b+", 3.25, new MyDate(22, "May", 1998)));
            XYZCorporation.AddPerson(new Employee("das", "O+", 30000, new MyDate(22, "June", 1997)));
            XYZCorporation.AddPerson(new Student("abba", "ab+", 3.5, new MyDate(27, "Augest", 1996)));
            //XYZ.ShowAll();
            //XYZ.SearchIndividual("p-1-S");
            XYZCorporation.DeletePerson("p-2-E");











        }
    }
}
