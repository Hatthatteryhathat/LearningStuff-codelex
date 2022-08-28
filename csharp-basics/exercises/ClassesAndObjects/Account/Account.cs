namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double ballance)
        {
            _name = name;
            _money = ballance;
        }

        public void Withdrawal(double moneyToWithdraw)
        {
            _money -= moneyToWithdraw;
        }

        public void Deposit(double moneyToDeposit)
        {
            _money += moneyToDeposit;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
