using System.Globalization;
using ProductExample;

Product product;

product = new Product();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
product.Name = Console.ReadLine();
Console.Write("Preço: ");
product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
product.Quantity = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Dados do produto: " + product);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int addQuantity = int.Parse(Console.ReadLine());
product.AddProducts(addQuantity);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + product);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser removido ao estoque: ");
int removeQuantity = int.Parse(Console.ReadLine());
product.RemoveProducts(removeQuantity);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + product);
Console.WriteLine();