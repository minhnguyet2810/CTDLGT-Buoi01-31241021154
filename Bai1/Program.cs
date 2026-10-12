
using System;

// Nhap 3 so nguyen
Console.Write("Nhap a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Nhap b: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Nhap c: ");
int c = int.Parse(Console.ReadLine()!);

// Tim so lon nhat va nho nhat
int max = Math.Max(a, Math.Max(b, c));
int min = Math.Min(a, Math.Min(b, c));

// Tinh tong va trung binh
long sum = (long)a + b + c;
double avg = (double)sum / 3;

// Xuat ket qua
Console.WriteLine($"Lon nhat: {max}");
Console.WriteLine($"Nho nhat: {min}");
Console.WriteLine($"Tong: {sum}");
Console.WriteLine($"Trung binh: {avg:F2}");
