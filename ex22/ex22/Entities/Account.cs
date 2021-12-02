using ex22.Entities.Exceptions;

namespace ex22.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            //Balance = balance;
            Deposit(balance);
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountExceptions("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new AccountExceptions("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
