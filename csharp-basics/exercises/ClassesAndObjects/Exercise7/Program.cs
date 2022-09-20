using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=--=-=-=-=--=-=-=-=-");

            Console.Write("How much money is in the account? :: ");
            SavingsAccount account = new SavingsAccount(decimal.Parse(Console.ReadLine()));

            Console.Write("What's the annual interrest rate? :: ");
            account.SetAnnualInterest(decimal.Parse(Console.ReadLine()));

            Console.Write("How long has the account been opened? :: ");
            int monthsPassed = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < monthsPassed; i++) 
            {
                account.AddMonthlyInterest();
            }

            Console.WriteLine("-=-=--=-=-=-=--=-=-=-=-");
            int counter = 1;
            int maxMonths = 4;

            while (true) 
            { 
                Console.WriteLine($"     >> Month : {counter} <<  ");

                Console.Write($"\n || Enter amount deposited this month : ") ;
                account.AddDeposit(decimal.Parse(Console.ReadLine()) );

                Console.Write($" || Enter amount withdrawn this month : ") ;
                account.SubtractWithdrawal(decimal.Parse(Console.ReadLine()) );
                Console.WriteLine("----------------");

                if (counter >= maxMonths) 
                {
                    break;
                }

                counter++;
            }

            Console.WriteLine($"Total deposited :: ${account.GetTotalDeposited()}");
            Console.WriteLine($"Total withdrawn :: ${account.GetTotalWithdrawn()}");
            Console.WriteLine($"Total interest earnings :: ${account.GetInterestEarned()}");
            Console.WriteLine($"Ending ballance :: ${account.GetBallance()}");
            Console.ReadKey();
        }
    }
}
