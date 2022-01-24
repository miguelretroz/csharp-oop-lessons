using System.Globalization;

namespace BankAccount
{
    internal class Account
    {
        public int Number { get; private set; }
        public string OwnerName { get; set; }
        public double Amount { get; private set; }

        public Account(int number, string ownerName)
        {
            Number = number;
            OwnerName = ownerName;
        }

        public Account(int number, string ownerName, double initialAmount) : this(number, ownerName)
        {
            Deposit(initialAmount);
        }

        public void Deposit(double depositAmount)
        {
            Amount += depositAmount;
        }

        public void Withdraw(double withdrawAmount)
        {
            Amount -= withdrawAmount + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Number
                + ", Titular: "
                + OwnerName
                + ", Saldo: $ "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
