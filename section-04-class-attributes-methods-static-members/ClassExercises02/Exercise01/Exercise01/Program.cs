using System.Globalization;
using Exercise01;

Rectangle rectangle = new Rectangle();

Console.WriteLine("Entre a largura e altura do retângulo:");
rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine(rectangle);
