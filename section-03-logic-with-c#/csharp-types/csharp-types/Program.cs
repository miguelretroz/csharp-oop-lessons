bool complete = false;
char genre = 'F';
char letter = '\u0041';
byte n1 = 127;
int n2 = 1000;
int n3 = 2147483647;
long n4 = 2147483648L;
float n5 = 4.5f; // Sem 'f' valor é entendido como double
double n6 = 4.5;
string name = "Maria Green";
object obj1 = "Alex Brown";
object obj2 = 4.5f;

Console.WriteLine(complete);
Console.WriteLine(genre);
Console.WriteLine(letter);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(n5);
Console.WriteLine(n6);
Console.WriteLine(name);
Console.WriteLine(obj1);
Console.WriteLine(obj2);


int intMinValue = int.MinValue;
int intMaxValue = int.MaxValue;
sbyte sbyteMinValue = sbyte.MinValue;
decimal decimalMaxValue = decimal.MaxValue;

Console.WriteLine(intMinValue);
Console.WriteLine(intMaxValue);
Console.WriteLine(sbyteMinValue);
Console.WriteLine(decimalMaxValue);
