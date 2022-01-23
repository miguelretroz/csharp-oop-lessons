using System.Globalization;

Console.Write("Entre com os valores A, B, C: ");
string[] inputLine = Console.ReadLine().Split(' ');

double A = double.Parse(inputLine[0], CultureInfo.InvariantCulture);
double B = double.Parse(inputLine[1], CultureInfo.InvariantCulture);
double C = double.Parse(inputLine[2], CultureInfo.InvariantCulture);

double triangleRectangleArea = A * C / 2;
double circleArea = Math.PI * Math.Pow(C, 2.0);
double trapeziumArea = (A + B) * C / 2.0;
double squareArea = Math.Pow(B, 2.0);
double rectangleArea = A * B;

Console.WriteLine("TRIANGULO: " + triangleRectangleArea.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circleArea.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPÁZIO: " + trapeziumArea.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + squareArea.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETÂNGULO: " + rectangleArea.ToString("F3", CultureInfo.InvariantCulture));
