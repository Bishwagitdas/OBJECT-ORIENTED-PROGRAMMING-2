using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInherit
{
    internal class XYZCorporation
    {
        private static Person[] persons = new Person[1000];
        private static int count = 0;


        internal static void AddPerson(Person p)
        {
            persons[count] = p;
            count++;
        }
        internal void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                persons[index].ShowInfo();
                index++;

            }
        }
        internal static bool SearchIndividual(string key,out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
               
            while(index < count)
            {
                if(persons[index].Id==key)
                {
                    Console.WriteLine("Person Found");
                    found=true;
                    persons[index].ShowInfo();
                    i = index;
                    break;
                }
                index++;
                       
            }
            if (!found)
                Console.WriteLine("Person not found");
            return found;
        }
        internal static void DeletePerson(string key)
        {
            int index;
           bool decision=SearchIndividual(key,out index);
           string name = persons[index].Name;
            if(decision)
            {
                persons[index] = null;
                Console.WriteLine(name + " has been deleted ");
            }
          


        }
    }
}
