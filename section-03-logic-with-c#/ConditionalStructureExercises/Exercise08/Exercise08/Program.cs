using System.Globalization;

double salary = double.Parse(Console.ReadLine());

Console.WriteLine();

double taxAmount = 0.0;

if (salary > 0 && salary <= 2000.00)
    Console.WriteLine("Isento");
else if (salary <= 3000.00)
    taxAmount = (salary - 2000.00) * 0.08;
else if (salary <= 4500.00)
    taxAmount = ((salary - 3000.00) * 0.18) + 80.00;
else
    taxAmount = ((salary - 4500.00) * 0.28) + 350.00;

Console.WriteLine("R$ " + taxAmount.ToString("F2", CultureInfo.InvariantCulture));
