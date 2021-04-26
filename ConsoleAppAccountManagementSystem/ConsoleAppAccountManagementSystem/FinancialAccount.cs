using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccountManagementSystem
{
    internal static class FinancialAcc
    {
        private static Account[] account = new Account[1000];
        private static int count = 0;

        internal static void AddAccount(Account a)
        {
            account[count] = a;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                account[index].ShowInfo();
                index++;
            }
        }

        internal static bool SearchIndividual(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    Console.WriteLine("Account Found");
                    account[index].ShowInfo();
                    found = true;
                    i = index;
                    return found; 
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not found");

            return found;
        }
        internal static void DeleteAccount(string key)
        {
            int index;
            bool decision = SearchIndividual(key, out index);
            string name = account[index].Name;
            if (decision)
            {
                account[index] = null;
                Console.WriteLine(name + " has been deleted.");
            }
        }
    }
}
