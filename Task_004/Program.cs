// Задача 4: 
// Напишите программу, которая принимает
// на вход три числа и выдает максимальное
// из этих чисел.

// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;


Console.Write("max = ");
Console.WriteLine(max);
