double value = double.Parse(Console.ReadLine());

if (value >= 0 && value <= 25)
    Console.WriteLine("Intervalo [0 a 25]");
else if (value > 25 && value <= 50)
    Console.WriteLine("Intervalo [25 a 50]");
else if (value > 50 && value <= 75)
    Console.WriteLine("Intervalo [50 a 75]");
else if (value > 75 && value <= 100)
    Console.WriteLine("Intervalo [75 a 100]");
else
    Console.WriteLine("Fora do intervalo");
