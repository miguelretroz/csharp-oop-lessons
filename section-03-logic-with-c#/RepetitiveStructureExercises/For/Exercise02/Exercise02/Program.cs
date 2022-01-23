int repeat = int.Parse(Console.ReadLine());

int inCount = 0, outCount = 0;

for (int i = 0; i < repeat; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x >= 10 && x <= 20)
        inCount++;
    else
        outCount++;
}

Console.WriteLine($"{inCount} in");
Console.WriteLine($"{outCount} out");
