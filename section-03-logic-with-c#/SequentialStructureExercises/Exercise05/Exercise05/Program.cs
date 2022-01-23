using System.Globalization;

Console.Write("Entre com o código, quantidade e valor unitário da peça 1: ");
string[] inputLinePieceOne = Console.ReadLine().Split(' ');
int pieceOneCode = int.Parse(inputLinePieceOne[0]);
int pieceOneQuantity = int.Parse(inputLinePieceOne[1]);
double pieceOneValue = double.Parse(inputLinePieceOne[2], CultureInfo.InvariantCulture);

Console.WriteLine();

Console.Write("Entre com o código, quantidade e valor unitário da peça 2: ");
string[] inputLinePieceTwo = Console.ReadLine().Split(' ');
int pieceTwoCode = int.Parse(inputLinePieceTwo[0]);
int pieceTwoQuantity = int.Parse(inputLinePieceTwo[1]);
double pieceTwoValue = double.Parse(inputLinePieceTwo[2], CultureInfo.InvariantCulture);

Console.WriteLine();

double valueTotal = pieceOneValue * pieceOneQuantity + pieceTwoValue * pieceTwoQuantity;
Console.WriteLine("Valor a pagar: R$ " + valueTotal.ToString("F2", CultureInfo.InvariantCulture));
