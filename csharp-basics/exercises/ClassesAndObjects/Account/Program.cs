using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("-=-=-==-=-=-=-=- Step 1");
            Account account1 = new Account("Marko's account", 100);
            account1.Deposit(20);
            Console.WriteLine(account1);

            Console.WriteLine("-=-=-==-=-=-=-=- Step 2");
            Account account2 = new Account("Matt's account", 1000);
            Account account3 = new Account("My account", 0);
            account2.Withdrawal(100);
            account3.Deposit(100);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

            Console.WriteLine("-=-=-==-=-=-=-=- Step 3");
            Account A = new Account("A" , 100);
            Account B = new Account("B" , 0);
            Account C = new Account("C" , 0);

            Transfer(A, B , 50);
            Transfer(B, C , 25);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch) 
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}
