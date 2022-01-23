using System.Globalization;

Console.Write("Número do funcionário: ");
int employeeNumber = int.Parse(Console.ReadLine());

Console.Write("Horas trabalhadas: ");
int hoursWorked = int.Parse(Console.ReadLine());

Console.Write("Valor por hora: ");
double hourlyRate = double.Parse(Console.ReadLine());

double salary = hourlyRate * hoursWorked;

Console.WriteLine($"NUMBER = {employeeNumber}");
Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
