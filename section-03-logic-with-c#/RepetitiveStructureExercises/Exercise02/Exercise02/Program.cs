string[] inputLine = Console.ReadLine().Split(' ');
int x = int.Parse(inputLine[0]);
int y = int.Parse(inputLine[1]);

while(x != 0 && y != 0)
{
    Console.WriteLine(Quadrant(x, y));

    inputLine = Console.ReadLine().Split(' ');
    x = int.Parse(inputLine[0]);
    y = int.Parse(inputLine[1]);
}

static string Quadrant(int x, int y)
{
    if (x == y && y == 0)
        return "Origem";
    else if (x == 0)
        return "Eixo X";
    else if (y == 0)
        return "Eixo Y";
    else if (x > 0)
    {
        if (y > 0)
            return "Q1";
        else
            return "Q4";
    }
    else
    {
        if (y > 0)
            return "Q2";
        else
            return "Q3";
    }
}