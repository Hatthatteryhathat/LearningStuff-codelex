using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson", 17.25m);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
