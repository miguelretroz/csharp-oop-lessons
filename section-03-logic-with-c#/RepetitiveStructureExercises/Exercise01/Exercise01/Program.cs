int password = int.Parse(Console.ReadLine());

while(password != 2002)
{
    Console.WriteLine("Senha Inválida!");
    password = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido!");
