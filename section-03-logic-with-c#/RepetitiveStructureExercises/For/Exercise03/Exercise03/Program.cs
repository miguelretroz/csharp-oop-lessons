using System.Globalization;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputLine = Console.ReadLine().Split(' ');
    double a = double.Parse(inputLine[0], CultureInfo.InvariantCulture);
    double b = double.Parse(inputLine[1], CultureInfo.InvariantCulture);
    double c = double.Parse(inputLine[2], CultureInfo.InvariantCulture);

    double media = (a * 2 + b * 3 + c * 5) / 10.0;

    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}
