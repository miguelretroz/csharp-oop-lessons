using System.Globalization;

string[] inputLine = Console.ReadLine().Split(' ');
int itemCode = int.Parse(inputLine[0]);
int itemQuantity = int.Parse(inputLine[1]);

Console.WriteLine();

double total = 0.0;

if (itemCode == 1)
    total = itemQuantity * 4.0;
else if (itemCode == 2)
    total = itemQuantity * 4.50;
else if (itemCode == 3)
    total = itemQuantity * 5.0;
else if (itemCode == 4)
    total = itemQuantity * 2.0;
else if (itemCode == 5)
    total = itemQuantity * 1.50;
else
    Console.WriteLine("Item não encontrado!");

Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
