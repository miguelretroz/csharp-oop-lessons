int alcohol = 0, gasoline = 0, diesel = 0, code;

code = int.Parse(Console.ReadLine());

while(code != 4)
{
    if (code == 1)
    {
        alcohol++;
    }
    else if (code == 2)
    {
        gasoline++;
    }
    else if (code == 3)
    {
        diesel++;
    }
    code = int.Parse(Console.ReadLine());
}

Console.WriteLine("MUITO OBRIGADO!");
Console.WriteLine("Álcool {0}", alcohol);
Console.WriteLine("Gasolina {0}", gasoline);
Console.WriteLine("Diesel {0}", diesel);
