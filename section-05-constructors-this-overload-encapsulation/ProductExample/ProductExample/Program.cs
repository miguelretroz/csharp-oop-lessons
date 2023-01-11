using System.Globalization;
using ProductExample;

Product product;

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string name = Console.ReadLine();
Console.Write("Preço: ");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Console.Write("Quantidade no estoque: ");
//int quantity = int.Parse(Console.ReadLine());

product = new Product(name, price);

Console.WriteLine();
Console.WriteLine("Dados do produto: " + product);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
product.AddProducts(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + product);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
product.RemoveProducts(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + product);