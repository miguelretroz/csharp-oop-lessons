using System.Globalization;

string[] inputLine = Console.ReadLine().Split(' ');
double x = double.Parse(inputLine[0], CultureInfo.InvariantCulture);
double y = double.Parse(inputLine[1], CultureInfo.InvariantCulture);

if (x == y && y == 0)
    Console.WriteLine("Origem");
else if (x == 0)
    Console.WriteLine("Eixo X");
else if (y == 0)
    Console.WriteLine("Eixo Y");
else if (x > 0)
{
    if (y > 0)
        Console.WriteLine("Q1");
    else
        Console.WriteLine("Q4");
}
else
{
    if (y > 0)
        Console.WriteLine("Q2");
    else
        Console.WriteLine("Q3");
}
