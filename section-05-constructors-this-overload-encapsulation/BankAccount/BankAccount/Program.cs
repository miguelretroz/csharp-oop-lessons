using System.Globalization;
using BankAccount;

Account account;

Console.Write("Entre o número da conta: ");
int accountNumber = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string ownerName = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char willBeDeposit = char.Parse(Console.ReadLine());

if (willBeDeposit == 's' || willBeDeposit == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double initialAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account = new Account(accountNumber, ownerName, initialAmount);
}
else
    account = new Account(accountNumber, ownerName);

Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.WriteLine(account);
Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double depositAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
account.Deposit(depositAmount);

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(account);
Console.WriteLine();

Console.Write("Entre um valor para saque: ");
double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
account.Withdraw(withdrawAmount);

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(account);
