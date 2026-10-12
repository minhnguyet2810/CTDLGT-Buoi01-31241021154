
using System;

Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 2 || n > 100000)
{
    Console.WriteLine("n khong hop le");
    return;
}

int max1 = 0;
int max2 = 0;
bool coMax1 = false;
bool coMax2 = false;

for (int i = 0; i < n; i++)
{
    Console.Write($"a[{i}]: ");
    int x = int.Parse(Console.ReadLine()!);

    if (!coMax1 || x > max1)
    {
        max2 = max1;
        coMax2 = coMax1;
        max1 = x;
        coMax1 = true;
    }
    else if (x < max1 && (!coMax2 || x > max2))
    {
        max2 = x;
        coMax2 = true;
    }
}

if (coMax2)
    Console.WriteLine($"{max1} {max2}");
else
    Console.WriteLine("NO");
