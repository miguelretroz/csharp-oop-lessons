using System.Globalization;
using Exercise02;

Employee employee = new Employee();

Console.Write("Nome: ");
employee.Name = Console.ReadLine();
Console.Write("Salário bruto: ");
employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine($"Funcionário: {employee}");
Console.WriteLine();

Console.Write("Digite a percentagem para aumentar o salário: ");
double increasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
employee.IncreaseSalary(increasePercentage);
Console.WriteLine();

Console.WriteLine("Dados atualizados: {0}", employee);
