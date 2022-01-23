using System.Globalization;

string product1 = "Computador";
string product2 = "Mesa de escritório";

byte age = 30;
int code = 5290;
char genre = 'M';

double price1 = 2100.0;
double price2 = 650.50;
double measure = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine("{0}, cujo preço é $ {1:F2}", product1, price1);
Console.WriteLine($"{product2}, cujo preço é $ {price2:F2}");
Console.WriteLine();

Console.WriteLine("Registro: " + age + " anos de idade, código " + code + " e gênero: " + genre);
Console.WriteLine();

Console.WriteLine("Medida com oito casas decimais: {0:F8}", measure);
Console.WriteLine($"Arredondado (três casas decimais): {measure:F3}");
Console.WriteLine("Separador decimal invariant culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));