using System.Globalization;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i += 1)
{
    string[] inputLine = Console.ReadLine().Split(' ');
    int x = int.Parse(inputLine[0]);
    int y = int.Parse(inputLine[1]);

    if (y == 0)
        Console.WriteLine("Divisão impossível");
    else
    {
        double result = (double)x / y;
        Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
    }
}
