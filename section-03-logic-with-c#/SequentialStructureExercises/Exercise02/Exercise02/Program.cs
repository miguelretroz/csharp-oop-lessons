using System.Globalization;

Console.Write("Entre com o raio do circulo: ");
double radius = double.Parse(Console.ReadLine());

Console.WriteLine();

double area = Math.PI * (Math.Pow(radius, 2.0));

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
