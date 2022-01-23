Console.WriteLine("Digite três números:");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine();

int result = Greater(n1, n2, n3);

Console.WriteLine("Maior {0}", result);

static int Greater(int numberOne, int numberTwo, int numberThree)
{
    int greater;

    if (numberOne > numberTwo && numberOne > numberThree)
        greater = numberOne;
    else if (numberTwo > numberThree)
        greater = numberTwo;
    else
        greater = numberThree;

    return greater;
}