using Exercise01;

Person personOne, personTwo;

personOne = new Person();
personTwo = new Person();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
personOne.Name = Console.ReadLine();
Console.Write("Idade: ");
personOne.Age = int.Parse(Console.ReadLine());


Console.WriteLine();

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
personTwo.Name = Console.ReadLine();
Console.Write("Idade: ");
personTwo.Age = int.Parse(Console.ReadLine());

Console.WriteLine();


if (personOne.Age > personTwo.Age)
    Console.WriteLine("Pessoa mais velha: {0}", personOne.Name);
else
    Console.WriteLine("Pessoa mais velha: {0}", personTwo.Name);
