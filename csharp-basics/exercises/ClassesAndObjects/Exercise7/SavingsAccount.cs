using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class SavingsAccount
    {
        private decimal _ballance;
        private decimal _annualInterest;

        private decimal _totalDeposited = 0;
        private decimal _totalWithdrawn = 0;
        private decimal _interestEarned = 0;

        public SavingsAccount(decimal initialBallance) 
        { 
            _ballance = initialBallance;
        }

        public decimal GetBallance() 
        { 
            return Math.Round(_ballance, 2);
        }

        public void SubtractWithdrawal(decimal withdrawl) 
        {
            _totalWithdrawn += withdrawl;
            _ballance -= withdrawl;
        }

        public decimal GetTotalWithdrawn() 
        {
            return Math.Round(_totalWithdrawn, 2);
        }

        public void AddDeposit(decimal deposit) 
        {
            _totalDeposited += deposit;
            _ballance += deposit;
        }

        public decimal GetTotalDeposited()
        {
            return Math.Round(_totalDeposited, 2);
        }

        public void SetAnnualInterest(decimal annualInterestUpdate)
        {
            _annualInterest = annualInterestUpdate;
        }
        
        public void AddMonthlyInterest() 
        {
            _interestEarned += _ballance * (_annualInterest / 12);
            _ballance += _ballance * (_annualInterest / 12); 
        }

        public decimal GetInterestEarned()
        {
            return Math.Round(_interestEarned, 2);
        }
    }
}
