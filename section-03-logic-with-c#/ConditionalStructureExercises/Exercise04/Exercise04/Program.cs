string[] inputLine = Console.ReadLine().Split(' ');
int startTime = int.Parse(inputLine[0]);
int endTime = int.Parse(inputLine[1]);

Console.WriteLine();

int duration = 0;

if (startTime == endTime)
    duration = 24;
else if (startTime > endTime)
{
    duration = (24 - startTime) + endTime;
} else
{
    duration = endTime - startTime;
}

Console.WriteLine("O jogo durou {0} hora(s)", duration);