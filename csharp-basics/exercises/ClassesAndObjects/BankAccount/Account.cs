using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        private string _name;
        private decimal _ballance;

        public Account(string name, decimal ballance) 
        { 
            this._name = name;
            this._ballance = ballance;
        }

        public string ShowUserNameAndBalance() 
        {
            return $"{_name}, ${string.Format("{0:#.##}", Math.Round(_ballance, 2))}";
        }
    }
}
