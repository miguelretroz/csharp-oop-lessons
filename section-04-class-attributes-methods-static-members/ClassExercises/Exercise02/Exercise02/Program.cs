using System.Globalization;
using Exercise02;

Employee employeeOne, employeeTwo;

employeeOne = new Employee();
employeeTwo = new Employee();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
employeeOne.Name = Console.ReadLine();
Console.Write("Salário: ");
employeeOne.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
employeeTwo.Name = Console.ReadLine();
Console.Write("Salário: ");
employeeTwo.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

double avgSalary = (employeeOne.Salary + employeeTwo.Salary) / 2.0;

Console.WriteLine("Salário médio = " + avgSalary.ToString("F2", CultureInfo.InvariantCulture));
