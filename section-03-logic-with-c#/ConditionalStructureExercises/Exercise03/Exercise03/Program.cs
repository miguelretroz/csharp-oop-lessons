string[] inputLine = Console.ReadLine().Split(' ');

int numberOne = int.Parse(inputLine[0]);
int numberTwo = int.Parse(inputLine[1]);

if ((numberOne % numberTwo) == 0 || (numberTwo % numberOne) == 0)
    Console.WriteLine("São Multiplos");
else
    Console.WriteLine("Não são Multiplos");
