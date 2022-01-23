int n = int.Parse(Console.ReadLine());

int factorial = n;

if (n == 0)
    factorial = 1;

for (int i = 1; i < n; i += 1)
{
    factorial *= n - i;
}

Console.WriteLine(factorial);
