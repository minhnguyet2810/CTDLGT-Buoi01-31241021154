
using System;
using System.Diagnostics;

// PHAN 1: Chon che do
Console.WriteLine("BAI 3 - TONG DOAN CON LIEN TIEP LON NHAT");
Console.WriteLine("1. Nhap mang thu cong (kiem thu)");
Console.WriteLine("2. Tu sinh mang (do thoi gian)");
Console.Write("Chon che do (1 hoac 2): ");

int mode = int.Parse(Console.ReadLine()!);

if (mode != 1 && mode != 2)
{
    Console.WriteLine("Che do khong hop le");
    return;
}

Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1)
{
    Console.WriteLine("n khong hop le");
    return;
}

int[] a = new int[n];

// PHAN 2: Tao du lieu
if (mode == 1)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"a[{i}]: ");
        a[i] = int.Parse(Console.ReadLine()!);
    }
}
else
{
    Random random = new Random(42);

    for (int i = 0; i < n; i++)
    {
        a[i] = random.Next(-100, 101);
    }

    Console.WriteLine($"Da tao {n} phan tu ngau nhien.");
}

// PHAN 3: Hai thuat toan
long SolveA(int[] arr)
{
    long best = long.MinValue;

    for (int i = 0; i < arr.Length; i++)
    {
        long sum = 0;

        for (int j = i; j < arr.Length; j++)
        {
            sum += arr[j];

            if (sum > best)
                best = sum;
        }
    }

    return best;
}

long SolveB(int[] arr)
{
    long current = arr[0];
    long best = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        current = Math.Max((long)arr[i], current + arr[i]);
        best = Math.Max(best, current);
    }

    return best;
}

// PHAN 4: Kiem tra ket qua
long resultA = SolveA(a);
long resultB = SolveB(a);

Console.WriteLine($"Ket qua A: {resultA}");
Console.WriteLine($"Ket qua B: {resultB}");
Console.WriteLine(resultA == resultB
    ? "Hai thuat toan cho ket qua GIONG NHAU"
    : "CANH BAO: Ket qua KHAC NHAU");

// PHAN 5: Do thoi gian
int repetitions = 5;

// Chay thu truoc khi do
SolveA(a);
SolveB(a);

double totalA = 0;
double totalB = 0;

for (int k = 0; k < repetitions; k++)
{
    var swA = Stopwatch.StartNew();
    long checkA = SolveA(a);
    swA.Stop();
    totalA += swA.Elapsed.TotalMilliseconds;

    var swB = Stopwatch.StartNew();
    long checkB = SolveB(a);
    swB.Stop();
    totalB += swB.Elapsed.TotalMilliseconds;

    if (checkA != checkB)
    {
        Console.WriteLine("Loi: Ket qua khong khop!");
        return;
    }
}

Console.WriteLine($"So lan do: {repetitions}");
Console.WriteLine($"Trung binh A: {totalA / repetitions:F4} ms");
Console.WriteLine($"Trung binh B: {totalB / repetitions:F4} ms");
