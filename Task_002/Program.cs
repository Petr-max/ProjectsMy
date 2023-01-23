// Задача 2: 
// Напишите программу, которая на вход 
// принимает два числа и выдает,
// какое число большее, а какое меньшее.
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int max = A;
int min = A;

if (A > max) max = A;
if (B > max) max = B;
if (A < min) min = A;
if (B < min) min = B;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);