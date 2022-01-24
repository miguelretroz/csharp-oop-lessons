using System.Globalization;
using StaticMembers;

Console.Write("Entre o valor do raio: ");
double radius = double.Parse(Console.ReadLine());

double circumference = Calculator.Circumference(radius);
double volume = Calculator.Volume(radius);
Console.WriteLine("Circunferência: " + circumference.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));