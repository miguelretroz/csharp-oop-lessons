using System.Globalization;

Console.Write("Entre com seu nome completo: ");
string fullName = Console.ReadLine();

Console.Write("Quantos quartos tem na sua casa? ");
int bedrooms = int.Parse(Console.ReadLine());

Console.Write("Entre com o preço de um produto: ");
double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
string[] inputLine = Console.ReadLine().Split(' ');
string lastName = inputLine[0];
int age = int.Parse(inputLine[1]);
double height = double.Parse(inputLine[2], CultureInfo.InvariantCulture);

Console.WriteLine();

Console.WriteLine("Você digitou: ");
Console.WriteLine(fullName);
Console.WriteLine(bedrooms);
Console.WriteLine(productPrice.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(lastName);
Console.WriteLine(age);
Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));