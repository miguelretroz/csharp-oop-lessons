using System.Globalization;
using TriangleExample;

Triangle x, y;

x = new Triangle();
y = new Triangle();

Console.WriteLine("Entre com as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2.0;
double xArea = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

p = (y.A + y.B + y.C) / 2.0;
double yArea = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

Console.WriteLine("Área de X = " + xArea.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + yArea.ToString("F4", CultureInfo.InvariantCulture));

if (xArea > yArea)
    Console.WriteLine("Maior área: X");
else
    Console.WriteLine("Maior área: Y");